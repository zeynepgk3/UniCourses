using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public int CategoryID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
        public double Price { get; set; }
        public int NumberOfStudent { get; set; }
        public int Duration { get; set; }

        [Column(TypeName = "bit")]
        public bool IsDone { get; set; }
        public double Score { get; set; }

        [Column(TypeName = "bit")]
        public bool State { get; set; }

        //  ( 1: N ) --> İlişkisi
        

        public ICollection<Lesson> Lessons { get; set; }
    }
}
