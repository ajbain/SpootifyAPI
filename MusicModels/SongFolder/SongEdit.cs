﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.SongFolder
{
    public class SongEdit
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public int AlbumId { get; set; }
        public int PlaylistId { get; set; }
        public int PlaylistSongId { get; set; }
        public int ProfileId { get; set; }

    }
}
