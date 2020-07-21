using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniCourses.Dal.Entities
{
    [Table("Country")]
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }

    }
}
