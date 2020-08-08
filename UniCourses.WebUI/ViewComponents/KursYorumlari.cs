using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.ViewComponents
{
    public class KursYorumlari : ViewComponent
    {
        Repository<Comment> rComment;
        Repository<Member> rMember;
        public KursYorumlari(Repository<Member> _rMember, Repository<Comment> _rComment)
        {
            rComment = _rComment;
            rMember = _rMember;  
        }
        public IViewComponentResult Invoke(int id)
        {
            List<Comment> commentlist = rComment.GetAll(x =>x.LessonID == id).ToList();
            //List<int> memberid =  //.GetAll(x=>x.MemberID);
            //List<Member> membername = rMember.GetAll(x => x.ID =  );

            return View(commentlist);
                
        }
    }
}
