using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.ViewComponents
{
    public class CategoriViewComponent : ViewComponent
    {
        Repository<Category> _rCategory;
        public CategoriViewComponent(Repository<Category> rCategory)
        {
            _rCategory = rCategory;
        }
        public IViewComponentResult Invoke()
        {

            return View(_rCategory.GetAll());

        }
    }
}
