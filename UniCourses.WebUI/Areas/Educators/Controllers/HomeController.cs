using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.ViewModels;

namespace UniCourses.WebUI.Areas.Educators.Controllers
{
    [Area("educators"), Authorize(Roles = "egitmen")]
    public class HomeController : Controller
    {
        Repository<Category> rCategory;
        Repository<Member> rMember;
        Repository<Admin> rAdmin;
        Repository<Educator> rEducator;
        Repository<Course> rCourse;
        Repository<Lesson> rLesson;
        Repository<Exam> rExam;
        Repository<CourseCategoryVM> rCourCat;
        public HomeController(Repository<Category> _rCategory, Repository<Exam> _rExam, Repository<Educator> _rEducator, Repository<Lesson> _rLesson, Repository<Member> _rMember, Repository<Admin> _rAdmin, Repository<Course> _rCourse, Repository<CourseCategoryVM> _rCourCat)
        {
            rCategory = _rCategory;
            rAdmin = _rAdmin;
            rMember = _rMember;
            rCourse = _rCourse;
            rCourCat = _rCourCat;
            rLesson = _rLesson;
            rExam = _rExam;
            rEducator = _rEducator;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Cikis()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        [HttpGet]
        public IActionResult Register(int id)
        {
            Member member = rMember.GetBy(x => x.ID == id);
            EducatorMemberVM educatorMemberVM = new EducatorMemberVM { Member = member};
            return View(educatorMemberVM);
        }
        [HttpPost]
        public IActionResult Register(Educator ed)
        {
            rEducator.Add(ed);
            return RedirectToAction("Index");
        }
        public IActionResult Rolata(int id)
        {
            var d = rMember.Bul(id);
            d.RoleNumber = 2;
            rMember.Save();
            return RedirectToAction("Register",new { id });
        }
        public IActionResult Egitmen(int id)
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult CreateCourse()
        {
            //List<SelectListItem> degerler = (from x in rCategory.ListTo()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = x.CategoryName,
            //                                     Value = x.Id.ToString()
            //                                 }).ToList();
            ViewBag.dgr = rCategory.GetAll(x => x.ParentID != null).Select(s=> new SelectListItem {Text=s.CategoryName, Value= s.Id.ToString()});
           
            return View();
        }
        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator= rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));
            course.Educatori = educator.ID;
            rCourse.Add(course);
            return RedirectToAction("CreateLesson");
        }
        [HttpGet]
        public IActionResult CreateLesson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateLesson(Course course)
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator = rEducator.GetBy(x => x.ID == Convert.ToInt32(uyeid));
            var cour = rCategory.GetAll(x => x.Id == course.Categoryi).FirstOrDefault();
            var coured = rEducator.GetAll(x => x.ID == course.Educatori).FirstOrDefault();
            course.Category = cour;
            course.Educator = coured;
            rCourse.Add(course);
            return RedirectToAction("Index");
        }

    }
}
