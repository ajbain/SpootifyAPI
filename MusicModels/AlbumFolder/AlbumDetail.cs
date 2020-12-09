﻿using MusicData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.AlbumFolder
{
    public class AlbumDetail
    {
        [Key]
        public int AlbumId { get; set; }
        public Guid OwnerId { get; set; }
        public object Title { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public object ModifiedUtc { get; set; }
        public string ArtistName { get; set; }
        public int ArtistId { get; set; }

    }
}
