using MySqlX.XDevAPI;
using System.Net;
using System.Net.Http.Headers;

namespace DatabaseSqlMusicApp
{
    public partial class Form1 : Form
    {

        BindingSource albumBindingSource = new BindingSource();
        BindingSource trackBindingSource = new BindingSource();

        public List<Album> albums = new List<Album>();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadAlbumsBtn_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();
            albums = albumsDAO.getAllAlbums();

            albumBindingSource.DataSource = albums;
            dataGridView1.DataSource = albumBindingSource;

            pictureBox.Load(albums[0].ImageUrl);

            if (albums[0].Tracks.Count() >= 1)
            {
                string url = albums[0].Tracks[0].VideoURL;
                webView.Source = new System.Uri(url);

                trackBindingSource.DataSource = albums[0].Tracks;
                dataGrid_TrackList.DataSource = trackBindingSource;
            }
            ComboBx_AlbumID.DataSource = albumsDAO.getAlbumIDs();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect the list and the grid view control
            albumBindingSource.DataSource = albumsDAO.searchTitles(searchField.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void searchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchBtn_Click(sender, e);
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // get the row number
            int rowClicked = dataGridView.CurrentRow.Index;

            string? imageUrl = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();
            //MessageBox.Show($"{imageUrl}");          

            try
            {
                pictureBox.Load(imageUrl);
            }
            catch (WebException)
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mike/1.0 (TestingCheckStuff@outlook.com) bot");
                httpClient.BaseAddress = new Uri(imageUrl);
                HttpResponseMessage response = httpClient.GetAsync(imageUrl).Result;
                response.EnsureSuccessStatusCode();
                //string result = response.Content.ReadAsStringAsync().Result;
                //MessageBox.Show(result);
                pictureBox.Load(httpClient.BaseAddress.ToString());
            }

            trackBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGrid_TrackList.DataSource = trackBindingSource;

            if (e.ColumnIndex == 1)
            {
                AlbumsDAO albumsDAO = new AlbumsDAO();
                trackBindingSource.DataSource = albumsDAO.getTracksUsingJoin((int)dataGridView.Rows[rowClicked].Cells[0].Value);
                dataGrid_TrackList.DataSource = trackBindingSource;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                AlbumName = txtBx_AlbumName.Text,
                ArtistName = txtBx_Artist.Text,
                Year = Int32.Parse(txtBx_Year.Text),
                ImageUrl = txtBx_ImageUrl.Text,
                Description = txtBx_Description.Text,
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.insertAlbum(album);
            MessageBox.Show($"{result} new rows inserted");
        }

        private void btn_DeleteTrack_Click(object sender, EventArgs e)
        {
            // get row number clicked

            int rowClicked = dataGrid_TrackList.CurrentRow.Index;
            //MessageBox.Show("" + rowClicked);
            int trackID = (int)dataGrid_TrackList.Rows[rowClicked].Cells[0].Value;
            //MessageBox.Show("" + trackID);

            AlbumsDAO albumsDao = new AlbumsDAO();
            albumsDao.deleteTrack(trackID);

            MessageBox.Show("Track Deleted");
            dataGrid_TrackList.DataSource = null;
            albums = albumsDao.getAllAlbums();
        }

        private void btn_Add_Update_Track_Click(object sender, EventArgs e)
        {
            Track track = new Track
            {
                Name = txtBx_TrackTitle.Text,
                Number = Int32.Parse(txtBx_Number.Text),
                VideoURL = txtBx_VideoUrl.Text,
                Lyrics = txtBx_Lyrics.Text,
                AlbumID = Int32.Parse(ComboBx_AlbumID.Text.Substring(0, 1))
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.insertTrack(track);
            MessageBox.Show($"{result} new rows inserted");
            dataGrid_TrackList.DataSource = null;
            albums = albumsDAO.getAllAlbums();
        }

        private void dataGrid_TrackList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;

            string? videoUrl = "";
            try
            {
                videoUrl = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();
            }
            catch (NullReferenceException)
            {
                videoUrl = dataGridView.Rows[0].Cells[3].Value.ToString();
            }
            finally
            {
                webView.Source = new System.Uri(videoUrl);
            }

        }

        private void btn_EditSelectedTrack_Click(object sender, EventArgs e)
        {
            UpdateSelection updateSelection = new UpdateSelection();

            if (dataGrid_TrackList != null && dataGrid_TrackList.RowCount > 0)
            {
                int rowClicked = dataGrid_TrackList.CurrentRow.Index;
                //MessageBox.Show("" + rowClicked);
                int trackID = (int)dataGrid_TrackList.Rows[rowClicked].Cells[0].Value;
                //MessageBox.Show("" + trackID);

                updateSelection.initialForm = this;
                updateSelection.grid = this.dataGrid_TrackList;

                updateSelection.trackID = trackID;
                updateSelection.trackTitle = dataGrid_TrackList.Rows[rowClicked].Cells[1].Value.ToString();
                updateSelection.trackNumber = (int)dataGrid_TrackList.Rows[rowClicked].Cells[2].Value;
                updateSelection.trackVideoUrl = dataGrid_TrackList.Rows[rowClicked].Cells[3].Value.ToString();
                updateSelection.trackLyrics = dataGrid_TrackList.Rows[rowClicked].Cells[4].Value.ToString();
                updateSelection.trackAlbumID = (int)dataGrid_TrackList.Rows[rowClicked].Cells[5].Value;
                updateSelection.Show();
                updateSelection.updateFields();
            }
            else if (dataGrid_TrackList.RowCount <= 0)
            {
                MessageBox.Show("Please Select a track.");
            }
        }
    }
}