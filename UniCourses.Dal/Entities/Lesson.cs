using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table(name: "Lesson")]
    public class Lesson
    {
        [Key]
        public int Id { get; set; }

        //LessonNo
        [DataType("int")]
        public int LessonNo { get; set; }

        [DataType("varchar(30)")]
        public string LessonName { get; set; }

        [DataType("varchar(100)")]
        public string LessonDescription { get; set; }

        //...

        public int Duration { get; set; }

        [DataType("bit")]
        public bool IsDone { get; set; }
        public int LastPoint { get; set; }
        // ( 1-N )
        public int? CourseID { get; set; }
        public Course Course { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Videos> Videos { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

    }

}
