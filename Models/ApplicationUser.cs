﻿using Microsoft.AspNetCore.Identity;
using ItKariera.Constants;

namespace ItKariera.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePicture { get; set; } = Constants.ProfilePicture.DefaultBase64Image;
    }
}
