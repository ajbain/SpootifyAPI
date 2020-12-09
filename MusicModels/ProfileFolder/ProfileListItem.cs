﻿using MusicData;
using MusicModels.SongFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicModels.ProfileFolder
{
    public class ProfileListItems
    {
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        public DateTime StartDate { get; set; }
        public List<SongDetail> Songs { get; set; } = new List<SongDetail>();
        public int MembershipLevel { get; set; }
        public DateTime RenewalDate { get; set; }
        public string Email { get; set; }
        public ContactPreference ContactPreference { get; set; }
        public List<Artist> FavoriteArtist { get; set; }
    }
}
