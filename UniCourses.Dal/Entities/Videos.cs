using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    public class Videos
    {
        
        [Key]
        public int Id { get; set; }
        public int LessonID { get; set; }
        public int? CourseID { get; set; }
        [StringLength(30), Column(TypeName = "Varchar(30)"), Display(Name = "İsim")]
        public string Name { get; set; }
        [Column(TypeName = "datetime"), Display(Name = "Kayıt Tarihi")]
        public DateTime UploadDate { get; set; }
        [StringLength(50), Column(TypeName = "nvarchar(MAX)"), Display(Name = "Video Path")]
        public string VideoPath { get; set; }
    }
}
