using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.ViewModels
{
    public class EducatorMemberVM : Controller
    {
        public Educator Educator { get; set; }
        public Member Member { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
