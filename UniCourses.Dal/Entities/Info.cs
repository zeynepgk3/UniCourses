using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    public class Info
    {
        public int ID { get; set; }// ID id Id

        [StringLength(50), Column(TypeName = "varchar(50)"), Required(ErrorMessage = "Bilgi Boş Geçilemez"), Display(Name = "Bilgi Adı")]
        public string Name { get; set; }

        public string Filter { get; set; }
    }
}
