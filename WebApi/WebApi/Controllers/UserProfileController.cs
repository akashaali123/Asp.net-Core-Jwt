﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        public UserProfileController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        [Authorize]
        [Route("GetUserProfile")]

        //GET : api/UserProfile/GetUserProfile
        
        public async Task<object> GetUserProfile()
        {
            //GET UserId claim which set in the subject property in application user Controller which have a token to a correspending Login Credentials Id
            var userId = User.Claims.FirstOrDefault(c => c.Type == "userId").Value;
            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
                user.fullName,
                user.Email,
                user.UserName
                
               
                
            };



        }


    }
}