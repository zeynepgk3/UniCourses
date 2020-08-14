using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string MemberName { get; set; }
        public string UserComment { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentState { get; set; } //Admin tarafından onaylanma durumu
        public int? MemberID { get; set; }
        public Member Member { get; set; }
        public int? LessonID { get; set; }
        public Lesson Lesson { get; set; }
        public int Rate { get; set; }
        public int? CourseID { get; set; }
        public Course Course { get; set; }
    }
}

