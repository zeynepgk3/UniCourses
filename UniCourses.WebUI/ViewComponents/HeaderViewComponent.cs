using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using UniCourses.WebUI.ViewModels;
using UniCourses.Dal.Contexts;
using System.Data.Entity;

namespace UniCourses.WebUI.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        Repository<Category> rCategory;
        Repository<Member> rMember;
        MyContext myContext;
        public HeaderViewComponent(MyContext _myContext, Repository<Member> _rMember, Repository<Category> _rcategory)
        {
            
            rCategory = _rcategory;
            rMember = _rMember;
            myContext = _myContext;
        }
        public IViewComponentResult Invoke()
        {
            //string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            // List<Member> members = rMember.GetAll(x => x.Mail == email).ToList();
            //IEnumerable<Member> member = myContext.Member.AsEnumerable().Where(o => o.ID.ToString() == User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value);
            //Member member = rMember.GetBy(x => x.Mail == User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Email).Value);
            //string a = ClaimTypes.Sid;
            //rMember.GetBy(r => r.ID.ToString() == a);
            return View(myContext.Category.Include(x => x.SubCategories).ToList());
        }
    }
}
