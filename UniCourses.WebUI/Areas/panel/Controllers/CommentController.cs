using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.Areas.panel.Controllers
{
    [Area("panel"), Authorize(Roles = "admin")]
    public class CommentController : Controller
    {
        Repository<Comment> rComment;
        public CommentController(Repository<Comment> _rComment)
        {
            rComment = _rComment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CommentList()
        {
            List<Comment> allComment = rComment.GetAll().ToList();
            return View(allComment);
        }
        public IActionResult Confirmation(int id)
        {
            Comment comment = rComment.GetFirstOrDefault(x => x.ID == id, includeProperties: "Course");
            comment.State = true; 
            rComment.Save();
            return RedirectToAction("CommentList");
        }
        public IActionResult ConfirmationCancel(int id)
        {
            Comment comment = rComment.GetFirstOrDefault(x => x.ID == id, includeProperties: "Course");
            comment.State = false;
            rComment.Save();
            return RedirectToAction("CommentList");
        }
        //public IActionResult EducatorPage(int id)
        //{
        //    Educator educator = rEducator.GetFirstOrDefault(x => x.ID == id);
        //    return View(educator);
        //}
    }
}
