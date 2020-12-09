using Microsoft.AspNet.Identity;
using Music.Services;
using MusicModels.PlaylistSongFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SpootifyAPI.Controllers
{
    public class PlaylistSongController : ApiController
    {
        /// <summary>
        /// Get a list of all playlists and songs
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            PlaylistSongServices playlistService = CreatePlaylistSongService();
            var playlist = playlistService.GetPlayListSongs();
            return Ok(playlist);
        }

        /// <summary>
        /// Assign a song to a playlist
        /// </summary>
        /// <param name="playlist">Pass playlistsong ID</param>
        /// <returns></returns>
        public IHttpActionResult Post(PlaylistSongCreate playlist)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePlaylistSongService();

            if (!service.CreatePlaylistSong(playlist))
                return InternalServerError();

            return Ok();
        }
        private PlaylistSongServices CreatePlaylistSongService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new PlaylistSongServices(userId);
            return noteService;
        }
        /// <summary>
        /// Get playlistsong by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(int id)
        {
            PlaylistSongServices playlistService = CreatePlaylistSongService();
            var note = playlistService.GetPlaylistSongById(id);
            return Ok(note);
        }
        /// <summary>
        /// Delete Playlist song by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePlaylistSongService();

            if (!service.DeletePlaylistSong(id))
                return InternalServerError();

            return Ok();
        }
    }
}