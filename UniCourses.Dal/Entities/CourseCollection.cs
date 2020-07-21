using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("CourseCollection")]
    public class CourseCollection
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int CollectionId { get; set; }
        public Collection collection { get; set; }
    }
}
