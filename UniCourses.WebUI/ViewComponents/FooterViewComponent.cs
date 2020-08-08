using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.ViewComponents
{
    public class FooterViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Info info = new Info { Name = "http://www.abc.com", Filter = "site" };
            return View(info);
        }
        
    }
}
