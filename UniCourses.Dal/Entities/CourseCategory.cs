using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("CourseCategory")]
    public class CourseCategory
    {
        
        public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
