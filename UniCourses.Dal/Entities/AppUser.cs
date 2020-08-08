using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniCourses.Dal.Entities
{
    public class AppUser : IdentityUser
    {
        public string  Name { get; set; }
        public string Surname { get; set; }
    }
}
