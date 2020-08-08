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
        public Cart()
        {
            Count = 1;
        }
        [Key]
        public int Id { get; set; }
        [ForeignKey("MemberId")]
        public Member member { get; set; }
        public int MemberId { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        [DataType("date")]
        public DateTime Date { get; set; }
        [Range(1, 1)]
        public int Count { get; set; }
        [NotMapped]
        public double Price { get; set; }
    }
}
