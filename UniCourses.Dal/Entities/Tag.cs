using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int CourseId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string TagName { get; set; }
    }
}
