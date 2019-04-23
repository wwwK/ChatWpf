﻿using Microsoft.AspNetCore.Identity;

namespace ChatWpf.Web.Server.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
