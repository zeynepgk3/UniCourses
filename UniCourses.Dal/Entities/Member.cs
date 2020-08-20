using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Net.Mail;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Member")]

    public class Member
    {
        [Key]
        public int ID { get; set; }

        [StringLength(40), Column(TypeName = "varchar(40)"), /*Required(ErrorMessage = "İsim boş geçilemez")*/ Display(Name = "Üye Adı")]
        public string NameSurName { get; set; }

        [Column(TypeName = "datetime"), Required(), Display(Name = "Kayıt Tarihi")]
        public DateTime RegisteryDate { get; set; }

        [Column(TypeName = "datetime"), Required(), Display(Name = "Giriş Tarihi")]
        public DateTime LogDate { get; set; }

        [Column(TypeName = "varchar(50)"), Required(ErrorMessage = "Mail Adresi Boş Geçilemez"), Display(Name = "Mail Adresi")]
        public string Mail { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Okul")]
        public string School { get; set; }

        [Column(TypeName = "varchar(50)"), Display(Name = "Bölüm")]
        public string Depart { get; set; }

        [StringLength(30), Column(TypeName = "varchar(30)"), Required(ErrorMessage = "Şifre Boş Geçilemez"), Display(Name = "Kullanıcı Şifresi")]
        public string Password { get; set; }

        [StringLength(21), Column(TypeName = "char(21)"), Display(Name = "IP")]
        public string IP { get; set; }

        [Column(TypeName = "int"), Required(), Display(Name = "Üye Rolü")]
        public int RoleNumber { get; set; }
        public ERole Role { get; set; }
        public Educator Educator { get; set; }
        public Picture Picture { get; set; }
        public int PictureID { get; set; }
        public string PictureURL { get; set; }
        /*
         */
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Course> Courses { get; set; }


    }
}
