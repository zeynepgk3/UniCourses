﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.ViewModels
{
    public class LessonCoursesVM : Controller
    {
        public List<Lesson> Lessons { get; set; }
        public Lesson Lesson { get; set; }
        public Cart Cart { get; set; }
        
        public Course Courses { get; set; }
        public List<Category> Categories { get; set; }
        public Educator Educator { get; set; }
    }
}
