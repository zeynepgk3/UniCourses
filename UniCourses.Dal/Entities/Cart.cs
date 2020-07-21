using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int MemberId { get; set; }
        [DataType("date")]
        public DateTime Date { get; set; }
    }
}
