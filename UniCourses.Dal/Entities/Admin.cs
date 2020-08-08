using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    public class Admin
    {
        public int ID { get; set; }

        [StringLength(30), Column(TypeName = "Varchar(30)"), Display(Name = "Adı Soyadı")]
        public string NameSurname { get; set; }

        [StringLength(20), Column(TypeName = "Varchar(20)"), Display(Name = "Mail Adresi"), Required(ErrorMessage = "Kullanıcı Adı boş geçilemez...")]
        public string Mail { get; set; }

        [StringLength(23), Column(TypeName = "Varchar(32)"), Display(Name = "Şifre"), Required(ErrorMessage = "Şifre boş geçilemez..."), DataType(DataType.Password)]
        public string Password { get; set; }
        public ERole Role { get; set; }
    }
}
