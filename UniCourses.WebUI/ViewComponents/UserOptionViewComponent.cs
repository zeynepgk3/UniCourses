using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.ViewModels;

namespace UniCourses.WebUI.ViewComponents
{
    public class UserOptionViewComponent: ViewComponent
    {
        Repository<Member> rMember;
        public UserOptionViewComponent(Repository<Member> _rMember)
        {
            rMember = _rMember;

        }

        public IViewComponentResult Invoke(string id)
        {
            Member member = rMember.GetBy(x => x.ID.ToString() == id);

            //EducatorMemberVM educ = new EducatorMemberVM { Member = member};
            return View(member);
        }
        
    }
}
