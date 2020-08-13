using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("CourseMember")]
    public class CourseMember
    {
            public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
            public Course Course { get; set; }
            public int? MemberId { get; set; }
        [ForeignKey("MemberId")]
            public Member Member{ get; set; }
            public int IsDone { get; set; }

    }
}
