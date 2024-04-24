using System;

namespace AlbumLogger.Data
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string RecordCompany { get; set; }

        public List<Song> Songs { get; set; } = new List<Song>();


    }
}
