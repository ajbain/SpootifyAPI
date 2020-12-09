using MusicData;
using MusicModels.ArtistFolder;
using MusicModels.SongFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.AlbumFolder
{
    public class AlbumListItem
    {
        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public List<SongDetail> Songs { get; set; } = new List<SongDetail>();
        //public string AlbumType
        //{

        //    get
        //    {
        //        string albumType = Enum.GetName(typeof(Genre), Genre);
        //        return albumType;
        //    }
        //}

        public string ArtistName { get; set; }

        //public int SongId { get; set; }
        //public string SongTitle { get; set; }
    }
}
