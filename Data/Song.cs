using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlbumLogger.Data
{
    public class Song
    {
        public int SongId { get; set; }

        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Length { get; set; }
        public int RecordID { get; set; }


    }
}
