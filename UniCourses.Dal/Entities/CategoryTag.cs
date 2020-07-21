using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("CategoryTag")]
    public class CategoryTag
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
