using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Picture")]
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public string ImageData { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }
    }
}
