using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicData
{
    public class AlbumArtist
    {
        [Key]
        public int AlbumArtistId { get; set; }
        //[Required]
        public int AlbumId { get; set; }
        //[ForeignKey(nameof(AlbumId))]
        //public virtual List<Album> Album { get; set; } = new List<Album>();
        public int ArtistId { get; set; }


        //[ForeignKey(nameof(ArtistId))]
        //public virtual List<Artist> Artist { get; set; } = new List<Artist>();
    }
}
