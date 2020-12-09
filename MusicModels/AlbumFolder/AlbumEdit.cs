﻿using MusicData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.AlbumFolder
{
    public class AlbumEdit
    {
        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
