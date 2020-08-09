using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("MemberId")]
        public Member member { get; set; }
        public int MemberId { get; set; }
        [DataType("date")]
        public DateTime RecDate { get; set; }
        [Column(TypeName = "char(10)")]
        public string TcNo { get; set; }
        public double OrderTotal { get; set; }
    }
}
