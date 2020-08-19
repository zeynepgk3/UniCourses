using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    public class Educator
    {
        public int ID { get; set; }
        public bool State { get; set; }

        [StringLength(30), Column(TypeName = "Varchar(30)"), Display(Name = "Adı Soyadı")]
        public string NameSurname { get; set; }

        [StringLength(50), Column(TypeName = "Varchar(50)"), Display(Name = "Mail Adresi")]
        public string Mail { get; set; }

        [StringLength(32), Column(TypeName = "Varchar(32)"), Display(Name = "Şifre"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Column(TypeName = "int"), Display(Name = "Toplam Öğrenci")]
        public int TotalStudent { get; set; }

        [StringLength(40), Column(TypeName = "Varchar(40)"), Display(Name = "Web Sitesi")]
        public string WebSite { get; set; }

        [StringLength(20), Column(TypeName = "Varchar(20)"), Display(Name = "Linkedin")]
        public string Linkedin { get; set; }

        [StringLength(20), Column(TypeName = "Varchar(20)"), Display(Name = "Youtube")]
        public string Youtube { get; set; }

        [StringLength(20), Column(TypeName = "Varchar(20)"), Display(Name = "Twitter")]
        public string Twitter { get; set; }

        [StringLength(20), Column(TypeName = "Varchar(20)"), Display(Name = "Instagram")]
        public string Instagram { get; set; }

        [StringLength(200), Column(TypeName = "Varchar(200)"), Display(Name = "Hakkımda")]
        public string About { get; set; }

        [StringLength(40), Column(TypeName = "Varchar(40)"), Display(Name = "Üniversite")]
        public string University { get; set; }

        [StringLength(40), Column(TypeName = "Varchar(40)"), Display(Name = "Bölüm")]
        public string Depart { get; set; }

        [StringLength(40), Column(TypeName = "Varchar(40)"), Display(Name = "Ünvan")]
        public string Job { get; set; }
        public ERole Role { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }
       
        public ICollection<Course> Courses { get; set; }

    }
}
