using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Collection")]
    public class Collection
    {
        [Key]
        public int CollectionId { get; set; }
        public int MemberId { get; set; }
        public int CourseId { get; set; }
        [StringLength(40), Column(TypeName = "varchar(40)")]
        public string CollectionName { get; set; }
    }
}
