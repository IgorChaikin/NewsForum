﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Models.AuthModels
{
    public class User : IdentityUser
    {
        public int TimeZoneOffset { get; set; }
        public int Year { get; set; }
    }
}
