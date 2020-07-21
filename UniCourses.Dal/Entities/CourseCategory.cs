using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("CourseCategory")]
    public class CourseCategory
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
