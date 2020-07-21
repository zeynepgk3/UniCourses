using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CaregoryName { get; set; }
    }
}
