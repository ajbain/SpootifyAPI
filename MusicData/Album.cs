﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicData
{
    public enum Genre { Rock = 1, Jazz, EasyListening, Punk, Folk, Pop, Christian, Country, Classical, HipHop, Latin, Holiday, Focus, Electronic, Indie, Decades, Alternative, Soul, K_Pop, Blues, Afro, Metal, Kids }
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        public string ArtistName { get; set; }
        public virtual List<Song> Songs { get; set; } = new List<Song>();
        public List<AlbumArtist> AlbumArtist { get; set; }

        //    public virtual List<Song> Songs { get; set; }
        [ForeignKey(nameof(Artist))]
        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
