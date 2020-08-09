using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
