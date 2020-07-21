using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("CourseWishList")]
    public class CourseWishList
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int WishListId { get; set; }
        
        public WishList WishList { get; set; }
        
    }
}
