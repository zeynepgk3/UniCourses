using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public int EducatorID { get; set; }

        [StringLength(30), Column(TypeName = "Varchar(30)"), Display(Name = "İsim")]
        public string Name { get; set; }
        [StringLength(40), Column(TypeName = "Varchar(40)"), Display(Name = "Başlık")]
        public string Title { get; set; }
        [StringLength(200), Column(TypeName = "Varchar(200)"), Display(Name = "Açıklama")]
        public string Description { get; set; }
        [StringLength(15), Column(TypeName = "Varchar(15)"), Display(Name = "Dil")]
        public string Language { get; set; }
        [StringLength(10), Column(TypeName = "Varchar(10)"), Display(Name = "Düzey")]
        public string Duzey { get; set; }
        [Column(TypeName = "float"), Display(Name = "Kurs Ücreti")]
        public float Price { get; set; }
        [Column(TypeName = "int"), Display(Name = "Öğrenci Sayısı")]
        public int NumberOfStudent { get; set; }
        [Column(TypeName = "int"), Display(Name = "Kurs Süresi")]
        public int Duration { get; set; }
        [Column(TypeName = "bit"), Display(Name = "Kurs Bitti Mi")]
        public bool IsDone { get; set; }
        [Column(TypeName = "float"), Display(Name = "Kurs Skoru")]
        public float Score { get; set; }
        [Column(TypeName = "bit"), Display(Name = "Kurs Onayı")]
        public bool State { get; set; }

        //  ( 1: N ) --> İlişkisi
        public Category Category { get; set; }
        public Educator Educator { get; set; }
        public int ImageID { get; set; }
        public string ImageURL { get; set; }
        public Image Image { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
