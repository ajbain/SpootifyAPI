﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.PlaylistFolder
{
    public class PlaylistCreate
    {
        public int SongId { get; set; }
        [Required]
        public string PlaylistName { get; set; }
        public int NumberOfSongs { get; set; }
        // public virtual List<PlaylistSong> Songs { get; set; } = new List<PlaylistSong>();


    }
}
