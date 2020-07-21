using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UniCourses.Dal.Entities
{
    public class WishList
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int MemberId { get; set; }
    }
}
