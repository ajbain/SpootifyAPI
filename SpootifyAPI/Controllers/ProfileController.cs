using Music.Services;
using MusicModels.ProfileFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SpootifyAPI.Controllers
{
    public class ProfileController : ApiController
    {
        public IHttpActionResult Get()
        {
            ProfileService profileService = CreateProfileService();
            var profile = profileService.GetProfiles();
            return Ok(profile);
        }

        private ProfileService CreateProfileService()
        {

            var profileService = new ProfileService();
            return profileService;
        }
        public IHttpActionResult Post(ProfileCreate profile)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateProfileService();

            if (!service.CreateProfile(profile))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            ProfileService profileService = CreateProfileService();
            var profile = profileService.GetProfileById(id);
            return Ok(profile);
        }
        public IHttpActionResult Put(ProfileEdit profile)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateProfileService();

            if (!service.UpdateProfile(profile))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateProfileService();

            if (!service.DeleteProfile(id))
                return InternalServerError();

            return Ok();
        }
    }
}