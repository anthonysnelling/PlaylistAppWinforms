using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System.Xml.Schema;

namespace DatabaseSqlMusicApp
{
    internal class AlbumsDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

        public List<Album> getAllAlbums()
        {
            // start with an empty list
            List<Album> returnAlbumList = new List<Album>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album album = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageUrl = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    album.Tracks = getTracksForAlbums(album.ID);
                    returnAlbumList.Add(album);
                }
            }
            connection.Close();

            return returnAlbumList;
        }

        public List<string> getAlbumIDs()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT albums.ID, albums.ALBUM_TITLE FROM `albums`", connection);

            List<AlbumsID> albumsIdList = new List<AlbumsID>();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AlbumsID alb = new AlbumsID
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                    };
                    albumsIdList.Add(alb);
                }
            }
            connection.Close();

            List<string> resultList = new List<string>();
            foreach (AlbumsID entry in albumsIdList)
            {
                resultList.Add($"{entry.ID} - {entry.AlbumName}");
            }

            return resultList;
        }

        public List<Album> searchTitles(string searchTerm)
        {
            // start with an empty list
            List<Album> returnAlbumList = new List<Album>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string albumTitle = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM ALBUMS WHERE ALBUM_TITLE LIKE @SearchText ";
            command.Parameters.AddWithValue("SearchText", albumTitle);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album album = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageUrl = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnAlbumList.Add(album);
                }
            }
            connection.Close();

            return returnAlbumList;
        }

        public int insertAlbum(Album album)
        {
            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO `albums`(`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@AlbumName, @ArtistName, @Year, @ImageUrl, @Description)";
            command.Parameters.AddWithValue("AlbumName", album.AlbumName);
            command.Parameters.AddWithValue("ArtistName", album.ArtistName);
            command.Parameters.AddWithValue("Year", album.Year);
            command.Parameters.AddWithValue("ImageUrl", album.ImageUrl);
            command.Parameters.AddWithValue("Description", album.Description);
            command.Connection = connection;

            int rowResult = command.ExecuteNonQuery();

            connection.Close();
            return rowResult;
        }

        public List<Track> getTracksForAlbums(int albumID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumID";
            command.Parameters.AddWithValue("albumID", albumID);
            command.Connection = connection;

            List<Track> resultList = new List<Track>();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                        AlbumID = reader.GetInt32(5),
                    };
                    resultList.Add(t);
                }
            }

            connection.Close();
            return resultList;
        }

        public string getAlbumTitleFromTrack(int albumID)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM ALBUMS WHERE ID = @albumID";
            command.Parameters.AddWithValue("albumID", albumID);
            command.Connection = connection;

            string result = "";
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result = reader.GetString(1);
                }
            }
            connection.Close();

            return result;
        }
        public List<JObject> getTracksUsingJoin(int albumID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT `track_title`, tracks.ID AS track_ID, albums.ALBUM_TITLE as Album_Title, `video_url`, `lyrics` FROM `tracks` JOIN albums ON albums_ID = albums.ID WHERE albums_ID = {albumID}";
            command.Parameters.AddWithValue("albumID", albumID);
            command.Connection = connection;

            List<JObject> resultList = new List<JObject>();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject newTrack = new JObject();

                    for (int i = 0;i < reader.FieldCount; i++) 
                    {
                        newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    resultList.Add(newTrack);
                }
            }

            connection.Close();
            return resultList;
        }

        internal int deleteTrack(int trackID)
        {
            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM tracks WHERE tracks.ID = @trackID";
            command.Parameters.AddWithValue("@trackID", trackID);
            command.Connection = connection;

            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
        public int insertTrack(Track track)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO `tracks`(`track_title`, `number`, `video_url`, `lyrics`, `albums_ID`) VALUES (@trackTitle, @number, @videoUrl, @lyrics, @albumsId)";
            command.Parameters.AddWithValue("trackTitle", track.Name);
            command.Parameters.AddWithValue("number", track.Number);
            command.Parameters.AddWithValue("videoUrl", track.VideoURL);
            command.Parameters.AddWithValue("lyrics", track.Lyrics);
            command.Parameters.AddWithValue("albumsId", track.AlbumID);
            command.Connection = connection;

            int rowResult = command.ExecuteNonQuery();

            connection.Close();
            return rowResult;
        }
        public int updateTrack(int trackID, string trackTitle, int number, string videoUrl, string lyrics, int albumsId)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "UPDATE `tracks` SET `track_title`= @trackTitle,`number`=@number,`video_url`=@videoUrl,`lyrics`=@lyrics,`albums_ID`= @albumsId WHERE ID = @trackID";
            command.Parameters.AddWithValue("trackTitle", trackTitle);
            command.Parameters.AddWithValue("number", number);
            command.Parameters.AddWithValue("videoUrl", videoUrl);
            command.Parameters.AddWithValue("lyrics", lyrics);
            command.Parameters.AddWithValue("albumsId", albumsId);
            command.Parameters.AddWithValue("trackID", trackID);
            command.Connection = connection;

            int rowResult = command.ExecuteNonQuery();

            connection.Close();
            return rowResult;
        }


    }
}
