using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Contexts;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.ViewComponents;
using UniCourses.WebUI.ViewModels;


namespace UniCourses.WebUI.Areas.uye.Controllers
{
    [Area("uye"), Authorize(Roles = "uye")]
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
        public IActionResult Index()
        {

            return View();
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
            if (category.ParentID == null) {
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
        [Route("/Kurs/{coursename?}/{lessonname?}/{id?}")]
        public IActionResult Lessons(int id)
        {
            Lesson lesson = rLesson.GetBy(x => x.Id == id);
            //Courses.Where(x=>x.KategoriId == kategoriId).OrderByDescending(x => x.Id).Take(adet).ToList
            Course course = rCourse.GetBy(x => x.Id == lesson.CourseID);
            List<Lesson> lessons = rLesson.GetAll(x => x.CourseID == course.Id).ToList();
            Educator educator = rEducator.GetBy(x => x.ID == course.EducatorID);
            Videos video = rVideos.GetBy(x => x.LessonID == id);
            List<Videos> videos = rVideos.GetAll(x => x.CourseID == course.Id).ToList();
            LessonCoursesVM lessonCourses = new LessonCoursesVM { Lessons = lessons, Courses = course, Educator = educator, Video = video, Lesson = lesson, Videos = videos };
            //return View(rCourse.GetAll(x=>x.CategoryID == id).ToList(), rCategory.GetAll().ToList());
            return View(lessonCourses);
        }
        [HttpPost, Route("/Kurs/{coursename?}/{lessonname?}/{id?}")]
        public IActionResult Lessons(Comment comment)
        {
            comment.MemberID = Convert.ToInt32(User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value);
            comment.Member = rMember.GetBy(x => x.ID == comment.MemberID);
            comment.CommentDate = DateTime.Now;
            comment.CommentState = 0;
            rComment.Add(comment);
            return RedirectToAction("Lessons");
        }
        /* public IActionResult Exams(int id)
        {
            
            List<int> lesID = rLesson.GetAll();
            Exam exam = rExam.GetAll(x=> x.LessonID == x=> x.lesID ).ToList();
            
            return View(courses);
        }*/
        public IActionResult Profil()
        {
            // List<Member> members = rMember.GetAll(x => x.Mail == email).ToList();
            //IEnumerable<Member> member = myContext.Member.AsEnumerable().Where(o => o.ID.ToString() == User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value);
            //Member member = rMember.GetBy(x => x.Mail == User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Email).Value);
            //string a = ClaimTypes.Sid;
            //rMember.GetBy(r => r.ID.ToString() == a);
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            return View(rMember.GetBy(r => r.ID.ToString() == uyeid));
        }
        public IActionResult CourseSinglePage(int id)
        {
            //Courses.Where(x=>x.KategoriId == kategoriId).OrderByDescending(x => x.Id).Take(adet).ToList();
            var course = rCourse.GetBy(c => c.Id == id);
            int uyeid = Convert.ToInt32(User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value);
            Cart cart = rCart.GetBy(
                x => x.MemberId == uyeid
                && x.CourseId == id);
            Course courses = rCourse.GetBy(x => x.Id == id);
            int educatid = courses.EducatorID;
            Educator educators = rEducator.GetBy(x => x.ID == educatid);
            List<Lesson> lesson = rLesson.GetAll(x => x.CourseID == id).ToList();
            LessonCoursesVM lessonCourses = new LessonCoursesVM { Lessons = lesson, Courses = courses, Educator = educators, Cart = cart };
            return View(lessonCourses);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize]
        public IActionResult AddToCart(Cart cartObj, int id)
        {
            var course = rCourse.GetBy(c => c.Id == id);
            cartObj.Id = 0;
            cartObj.Course = course;
            cartObj.CourseId = course.Id;
            cartObj.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                ///cartObj.MemberId = claim.Value
                ///
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "id")); //Enum.GetName(typeof(ERole), ERole.uye))
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.uye))); //Enum.GetName(typeof(ERole), ERole.uye))
                                                                                                             //claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"admin"));
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
                claimsPrincipal.AddIdentity(claimsIdentity);
                string uyeid = User.Claims.FirstOrDefault(f => f.Type == System.Security.Claims.ClaimTypes.Sid).Value;
                cartObj.MemberId = Convert.ToInt32(uyeid);
                //insert
                rCart.Update(cartObj);
                return RedirectToAction("Index", "Cart");
            }
            else
            {
                Cart cart = new Cart()
                {
                    Course = course,
                    CourseId = course.Id
                };
                return View(cart);
            }
        }
        public IActionResult Sepet()
        {
            return View();
        }
        
        public IActionResult Ayarlar()
        {/*
        Image img = myContext.Images.FirstOrDefault(i => i.CourseID==2);
        string imageBase64Data = Convert.ToBase64String(img.ImageData);
        string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
        ViewBag.ImageTitle = img.ImageTitle;
        ViewBag.ImageDataUrl = imageDataURL;*/
        return View();
        }
        public IActionResult Kurslarim()
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            IEnumerable<CourseMember> courseMembers = rCourseMember.GetAllLazy(x => x.MemberId == Convert.ToInt32(uyeid), includeProperties: "Course");


            return View(courseMembers);
        }
    }
}
