namespace DatabaseSqlMusicApp
{
    public class Album
    {
        public int ID { get; set; }
        public string? AlbumName { get; set; }
        public string? ArtistName { get; set; }
        public int Year { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }

        public List<Track> Tracks { get; set; }
    }
}
