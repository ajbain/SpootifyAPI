using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.SongFolder
{
    public class SongDetail
    {
        public int SongId { get; set; }
        public string Title { get; set; }


        public string Lyrics { get; set; }
        public bool IsExplicit { get; set; }

        public string AlbumName { get; set; }
    }
}
