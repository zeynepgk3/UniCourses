using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Question")]
    public class Question
    {
        public int QuestionId { get; set; }
        public int Line { get; set; }

        public int? ExamId { get; set; } // Exam - Question
        [Column(TypeName = "bit")]
        public bool IsTrue { get; set; }

        //( 1:N ) Exam - Question
        public Exam Exam { get; set; }

    }
}
