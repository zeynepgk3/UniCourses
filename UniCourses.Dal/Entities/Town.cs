using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Town")]
    public class Town
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

    }
}
