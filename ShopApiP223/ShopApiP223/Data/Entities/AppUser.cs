﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApiP223.Data.Entities
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
