using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net.Mail;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Count = 0;
        }
        public int Id { get; set; }
        [StringLength(50), Column(TypeName = "Varchar(50)"), Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }
        public int? ParentID { get; set; }
        [Display(Name = "Üst Kategori")]
        public Category ParentCategory { get; set; }
        [Display(Name = "Alt Kategoriler")]
        public ICollection<Category> SubCategories { get; set; }
        public ICollection<Course> Courses { get; set; }
        [Display(Name = "Görüntülenme Sırası")]
        public int? DisplayIndex { get; set; }
        public int Count { get; set; }
    }
}
