﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicData
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        [Required]
        public string Title { get; set; }

        public string AlbumName { get; set; }
        [ForeignKey(nameof(Album))]
        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }
        [Required]
        public string Lyrics { get; set; }

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        // public int? SongCount { get; set; }
        [Required]

        public bool IsExplicit { get; set; }
        public string PlaylistName { get; set; }
    }
}
