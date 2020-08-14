using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.ViewModels
{
    public class CartVM
    {

        public IEnumerable<Cart> ListCart { get; set; }
        public Order Order { get; set; }
    }
}
