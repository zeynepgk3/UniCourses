using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Exam")]
    public class Exam
    {
        public int ExamId { get; set; }
        public int? MemberId { get; set; }
        public int Score { get; set; }
        public string ExamName { get; set; }
        public Lesson Lesson { get; set; }
        public int? LessonID { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
