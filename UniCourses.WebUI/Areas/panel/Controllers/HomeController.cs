using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Contexts;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.ViewModels;

namespace UniCourses.WebUI.Areas.panel.Controllers
{
    [Area("panel"), Authorize(Roles = "admin")]
    public class HomeController : Controller
    {
        Repository<Category> rCategory;
        Repository<Member> rMember;
        Repository<Admin> rAdmin;
        Repository<Educator> rEducator;
        Repository<Course> rCourse;
        Repository<Cart> rCart;
        Repository<Comment> rComment;
        Repository<Lesson> rLesson;
        Repository<Exam> rExam;
        Repository<CourseCategoryVM> rCourCat;
        Repository<Videos> rVideos;
        Repository<Image> rImage;
        Repository<CourseMember> rCourseMember;
        MyContext myContext;
        public HomeController(Repository<Videos> _rVideos, Repository<CourseMember> _rCourseMember, Repository<Image> _rImage, Repository<Comment> _rComment, MyContext _myContext, Repository<Cart> _rCart, Repository<Category> _rCategory, Repository<Exam> _rExam, Repository<Educator> _rEducator, Repository<Lesson> _rLesson, Repository<Member> _rMember, Repository<Admin> _rAdmin, Repository<Course> _rCourse, Repository<CourseCategoryVM> _rCourCat)
        {
            rCategory = _rCategory;
            rAdmin = _rAdmin;
            rMember = _rMember;
            rCourse = _rCourse;
            rCourseMember = _rCourseMember;
            rCourCat = _rCourCat;
            rLesson = _rLesson;
            rExam = _rExam;
            rCart = _rCart;
            rEducator = _rEducator;
            rComment = _rComment;
            myContext = _myContext;
            rVideos = _rVideos;
            rImage = _rImage;

        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<Course> courses = rCourse.GetAll().ToList();
            List<Educator> educators = rEducator.GetAll().ToList();
            List<Member> members = rMember.GetAll().ToList();
            float sum = 0;
            int totalStudent = 0;

            foreach (Course course in courses)
            {
                sum += course.NumberOfStudent * course.Price;
            }
             

            foreach (Educator educator in educators)
            {
                totalStudent += educator.TotalStudent;
            }
            EducatorMemberVM educatorMemberVM = new EducatorMemberVM
            {
                EducatorList = educators,
                MemberList = members,
                CourseList = courses,
                totalSum = sum

            };

            return View(educatorMemberVM);
        }
        public IActionResult Build()
        {
            List<Educator> allEducator = rEducator.GetAll().ToList();
            return View(allEducator);
        }
        public IActionResult EducatorList()
        {
            List<Educator> allEducator = rEducator.GetAll().ToList();
            return View(allEducator);
        }
        public IActionResult EducatorPage(int id)
        {
            Educator educator = rEducator.GetFirstOrDefault(x => x.ID == id);
            return View(educator);
        }
        public IActionResult CourseList()
        {

            List<Course> courses = rCourse.GetAllLazy(includeProperties: "Category").ToList();


            return View(courses);
        }
        public IActionResult Confirmation(int id)
        {


            Course course = rCourse.GetBy(x => x.Id == id);
            course.State = true;
            rCourse.Save();
            return RedirectToAction("CourseList");
        }
        public IActionResult ConfirmationCancel(int id)
        {


            Course course = rCourse.GetBy(x => x.Id == id);
            course.State = false;
            rCourse.Save();
            return RedirectToAction("CourseList");
        }
        public IActionResult ConfirmationEducator(int id)
        {


            Educator educator = rEducator.GetBy(x => x.ID == id);
            educator.State = true;
            rEducator.Save();
            return RedirectToAction("EducatorList");
        }
        public IActionResult ConfirmationCancelEducator(int id)
        {
            Educator educator = rEducator.GetBy(x => x.ID == id);
            educator.State = false;
            rEducator.Save();
            return RedirectToAction("EducatorList");
        }
        public async Task<IActionResult> Cikis()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        public IActionResult Courses(int id)
        {
            Category category = rCategory.GetBy(x => x.Id == id);
            List<Category> Subcategories = null;
            if (category.ParentID == null)
            {
                Subcategories = myContext.Category.Include(x => x.SubCategories).Include(x => x.Courses).ToList();
            }
            List<Course> courses = rCourse.GetAll(x => x.CategoryID == id).ToList();
            List<Category> categories = myContext.Category.Include(x => x.SubCategories).ToList();
            

            CourseCategoryVM courcatVM = new CourseCategoryVM
            {
                Courses = courses,
                Categories = categories,
                Scategories = Subcategories
               

            };
            return View(courcatVM);
        }
    }
}
