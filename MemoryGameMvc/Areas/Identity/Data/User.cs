﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MemoryGameMvc.Models;
using Microsoft.AspNetCore.Identity;

namespace MemoryGameMvc.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        [PersonalData]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First Name should be in range between 3 and 25")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [PersonalData]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Last Name should be in range between 3 and 25")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public ICollection<List> List { get; set; }
    }
}
