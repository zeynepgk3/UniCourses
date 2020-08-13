using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Image")]
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public string ImageData { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
