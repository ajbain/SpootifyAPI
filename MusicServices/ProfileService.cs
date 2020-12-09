﻿
using MusicData;
using MusicModels;
using MusicModels.ArtistFolder;
using MusicModels.ProfileFolder;
using MusicModels.SongFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Services
{
    public class ProfileService
    {
        public bool CreateProfile(ProfileCreate model)
        {
            var entity =
                new Profile()
                {

                    ProfileId = model.ProfileId,
                    UserName = model.UserName,
                    StartDate = model.StartDate,
                    MembershipLevel = model.MembershipLevel,
                    RenewalDate = model.RenewalDate,
                    Email = model.Email,
                    ContactPreference = model.ContactPreference,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Profile.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ProfileListItems> GetProfiles()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Profile

                        .Select(
                            e =>
                                new ProfileListItems
                                {
                                    ProfileId = e.ProfileId,
                                    UserName = e.UserName,
                                    StartDate = e.StartDate,
                                    MembershipLevel = e.MembershipLevel,
                                    RenewalDate = e.RenewalDate,
                                    Email = e.Email,
                                    ContactPreference = e.ContactPreference,
                                    Songs = e.Songs.Select(
                                        b =>
                                            new SongDetail
                                            {
                                                SongId = b.SongId,
                                                Title = b.Title,
                                                IsExplicit = b.IsExplicit,
                                                Lyrics = b.Lyrics,
                                                AlbumName = b.Album.Title
                                            }).ToList(),
                                    FavoriteArtist = e.FavoriteArtist
                                    //PlaylistName =e.PlaylistId
                                }
                        );

                return query.ToArray();
            }
        }
        public ProfileDetail GetProfileById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profile
                        .Single(e => e.ProfileId == id);
                return
                    new ProfileDetail
                    {
                        ProfileId = entity.ProfileId,
                        UserName = entity.UserName,
                        StartDate = entity.StartDate,
                        MembershipLevel = entity.MembershipLevel,
                        RenewalDate = entity.RenewalDate,
                        Email = entity.Email,
                        ContactPreference = entity.ContactPreference,

                    };
            }

        }
        public bool UpdateProfile(ProfileEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profile
                        .Single(e => e.ProfileId == model.ProfileId);

                entity.UserName = model.UserName;

                entity.MembershipLevel = model.MembershipLevel;
                entity.RenewalDate = model.RenewalDate;
                entity.Email = model.Email;
                entity.ContactPreference = model.ContactPreference;


                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteProfile(int profileId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Profile
                        .Single(e => e.ProfileId == profileId);

                ctx.Profile.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
