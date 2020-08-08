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

            [StringLength(40), Column(TypeName = "varchar(40)"), Required(ErrorMessage = "İsim boş geçilemez"), Display(Name = "Üye Adı")]
            public string NameSurName { get; set; }

            [StringLength(5), Column(TypeName = "varchar(5)"), Display(Name = "Cinsiyet")]
            public string Gender { get; set; }

            [Column(TypeName = "date"), Required(ErrorMessage = "Doğum tarihi boş geçilemez"), Display(Name = "Doğum Tarihi")]
            public DateTime BirthDate { get; set; }

            [Column(TypeName = "datetime"), Required(), Display(Name = "Kayıt Tarihi")]
            public DateTime RegisteryDate { get; set; }

            [Column(TypeName = "datetime"), Required(), Display(Name = "Giriş Tarihi")]
            public DateTime LogDate { get; set; }

            [Column(TypeName = "varchar(50)"), Required(ErrorMessage = "Mail Adresi Boş Geçilemez"), Display(Name = "Mail Adresi")]
            public string Mail { get; set; }

            [StringLength(30), Column(TypeName = "varchar(30)"), Required(ErrorMessage = "Şifre Boş Geçilemez"), Display(Name = "Kullanıcı Şifresi")]
            public string Password { get; set; }

            [StringLength(10), Column(TypeName = "char(10)"), Required(ErrorMessage = "Telefon Boş Geçilemez"), Display(Name = "Telefon Numarası")]
            public string Phone { get; set; }

            [StringLength(21), Column(TypeName = "char(21)"), Display(Name = "IP")]
            public string IP { get; set; }

            [Column(TypeName = "int"), Required(), Display(Name = "Üye Rolü")]
            public int RoleNumber { get; set; }
            public ERole Role { get; set; }
            public Educator Educator { get; set; }
            /*
             */
            public virtual ICollection<Address> Addresses { get; set; }
            public virtual ICollection<Collection> Collections { get; set; }
            public virtual ICollection<Comment> Comments { get; set; }


        }
    }
