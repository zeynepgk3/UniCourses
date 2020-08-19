using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MediaToolkit;
using MediaToolkit.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Contexts;
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
        Repository<Videos> rVideos;
        IWebHostEnvironment _environment;
        Repository<Image> rImage;
        Repository<Comment> rComment;
        MyContext myContext;
        public HomeController(Repository<Videos> _rVideos, Repository<Comment> _rComment, Repository<Image> _rImage, IWebHostEnvironment environment, MyContext _myContext, Repository<Category> _rCategory, Repository<Exam> _rExam, Repository<Educator> _rEducator, Repository<Lesson> _rLesson, Repository<Member> _rMember, Repository<Admin> _rAdmin, Repository<Course> _rCourse, Repository<CourseCategoryVM> _rCourCat)
        {
            rCategory = _rCategory;
            rAdmin = _rAdmin;
            rMember = _rMember;
            rCourse = _rCourse;
            rCourCat = _rCourCat;
            rLesson = _rLesson;
            rExam = _rExam;
            rEducator = _rEducator;
            _environment = environment;
            rVideos = _rVideos;
            myContext = _myContext;
            rComment = _rComment;
            rImage = _rImage;
        }
        public IActionResult Index()
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator = rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));
            List<Course> courses = rCourse.GetAllLazy(x => x.EducatorID == educator.ID, includeProperties: "Lessons").ToList();//kursa lessoncount eklenince lazy loading ile commentler cekilecek.
            /*List<Comment> comments = new List<Comment>();
            //rComment.GetAll(x => x.CourseID == 1);
            foreach (var item in courses)
            {
                foreach (var item2 in comments)
                {
                    item2.UserComment = rComment.GetBy(x=>x.CourseID== item.Id).UserComment;
                    item2.MemberName = rComment.GetBy(x=>x.CourseID== item.Id).MemberName;
                    item2.CommentDate = rComment.GetBy(x=>x.CourseID== item.Id).CommentDate;
                    item2.Rate = rComment.GetBy(x=>x.CourseID== item.Id).Rate;
                    rComment.Save();
                }
            }*/
            LessonCoursesVM lessonCoursesVM = new LessonCoursesVM
            {
                Educator = educator,
                Coursess = courses
            };
            return View(lessonCoursesVM);
        }
        public IActionResult Course(int id)
        {
            List<Course> course = rCourse.GetAllLazy(x => x.Id == id, includeProperties: "Lessons").ToList();
            return View(course);
        }
        public IActionResult EditCourse(int id)
        {
            Course course = rCourse.Bul(id);
            return View(course);
        }
        [HttpPost]
        public IActionResult EditCourse(Course course)
        {
            Course changedcourse = rCourse.Bul(course.Id);
            changedcourse.Name = course.Name;
            changedcourse.Price = course.Price;
            changedcourse.Title = course.Title;
            changedcourse.Description = course.Description;
            rCourse.Update(changedcourse);
            return RedirectToAction("EditCourse", new { course.Id});
        }
        public IActionResult Build()
        {
            return View();
        }
        public IActionResult Statisctic()
        {
            return View();
        }
        public IActionResult CourseList()
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator = rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));
            List<Course> courses = rCourse.GetAll(x => x.EducatorID == educator.ID).ToList();
            return View(courses);
        }
        [HttpPost]
        public IActionResult Profile(Educator educator)
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator changededucator = rEducator.Bul(Convert.ToInt32(uyeid));

            changededucator.NameSurname = educator.NameSurname;
            changededucator.Job = educator.Job;
            changededucator.University = educator.University;
            changededucator.Twitter = educator.Twitter;
            changededucator.Instagram = educator.Instagram;
            changededucator.Linkedin = educator.Linkedin;
            changededucator.WebSite = educator.WebSite;
            rEducator.Update(changededucator);
            return RedirectToAction("Profile", new { educator.ID });
        }
        public IActionResult Profile()
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator = rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));

            return View(educator);
        }

        public IActionResult RemoveCourse(int id)
        {
            return View(rCourse.GetBy(x=>x.Id == id));
        }
        public IActionResult Sil(int id, string mail, string password)
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator = rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));
            if (mail == educator.Mail && password == educator.Password)
            {
                Course course = rCourse.Bul(id);
                course.State = false;
                rCourse.Update(course);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("RemoveCourse");
            }
            
        }
        [HttpGet]
        public IActionResult CreateCourse()
        {
            /*List<SelectListItem> degerler = (from x in rCategory.ListTo()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.Id.ToString()
                                             }).ToList();
            */
            ViewBag.dgr = rCategory.GetAll(x => x.ParentID != null).Select(s=> new SelectListItem {Text=s.CategoryName, Value= s.Id.ToString()});
            return View();
        }
        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
            Image img = new Image();
            foreach (var file in Request.Form.Files)
            {
                img.ImageTitle = file.FileName;
                var yeniresimad = Guid.NewGuid() + img.ImageTitle.Replace(" ", "_");
                var yuklenecekyer = Path.Combine(Directory.GetCurrentDirectory(),
                            "wwwroot/img/" + yeniresimad);
                var stream = new FileStream(yuklenecekyer, FileMode.Create);
                file.CopyTo(stream);
                img.ImageData = yeniresimad;
            }
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator = rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));
            course.EducatorID = educator.ID;
            course.ImageURL = img.ImageData;
            rCourse.Add(course);
            rCategory.GetBy(x => x.Id == course.CategoryID).Count++;
            rCategory.Save();
            img.CourseID = course.Id;
            rImage.Add(img);
            course.ImageID = img.Id;
            rCourse.Update(course);
            return RedirectToAction("CreateLesson");
        }

        [HttpGet]
        public IActionResult CreateLesson()
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator = rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));
            ViewBag.dgr = rCourse.GetAll(x => x.EducatorID == educator.ID).Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() });
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateLesson(Lesson lesson, Videos video, IFormFile file)
        {
            rLesson.Add(lesson);
            if (file.Length > 0)
            {
                try
                {
                    int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid)?.Value);
                    string userName = (User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value);
                    string folder = Path.Combine(_environment.WebRootPath, "video");
                    string url = @"\video\" + userName.Replace(" ", "_") + @"\" + file.FileName;
                    string pathString = Path.Combine(folder, userName.Replace(" ", "_"));
                    if (!Directory.Exists(pathString))
                    {
                        Directory.CreateDirectory(pathString);
                    }
                    var filePath = Path.Combine(pathString, file.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        // rVideos.Add(new Videos(video.Name, DateTime.Now, url, video.LessonID));
                        video.Name = lesson.LessonName;
                        video.LessonID = lesson.Id;
                        video.CourseID = lesson.CourseID;
                        video.UploadDate = DateTime.Now;
                        video.VideoPath = url;
                        rVideos.Add(video);
                    }
                    
                    var inputFile = new MediaFile { Filename = @"C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\wwwroot" + video.VideoPath };
                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                    }
                    lesson.Duration = (int)inputFile.Metadata.Duration.TotalSeconds;
                    rCourse.GetBy(x => x.Id == lesson.CourseID).Duration += lesson.Duration;
                    rCourse.Save();
                    rLesson.Update(lesson);
                    
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR: " + ex.Message.ToString();
                }
            }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }
            return RedirectToAction("Index");
        }
        public IActionResult UploadVideo(int id)
        {
            
            //ViewBag.Lessonid = rLesson.GetBy(x => x.Id == id);
            Lesson lesson = rLesson.GetBy(x => x.Id == id);
            Course course = rCourse.GetBy(x => x.Id == lesson.CourseID);
            ViewBag.Courseid = course.Id;
            ViewBag.CourseName = course.Name;
            ViewBag.LessonName = lesson.LessonName;
            ViewBag.Lessonid = lesson.Id;
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> UploadVideo(Videos video, IFormFile file)
        {
            if (file.Length > 0)
            {
                try
                {
                    int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid)?.Value);
                    string userName = (User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value);
                    string folder = Path.Combine(_environment.WebRootPath, "video");
                    string url = @"\video\" + userName.Replace(" ", "_") + @"\" + file.FileName;
                    string pathString = Path.Combine(folder, userName.Replace(" ", "_"));
                    if (!Directory.Exists(pathString))
                    {
                        Directory.CreateDirectory(pathString);
                    }
                    var filePath = Path.Combine(pathString, file.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        // rVideos.Add(new Videos(video.Name, DateTime.Now, url, video.LessonID));
                       
                        video.UploadDate = DateTime.Now;
                        video.VideoPath = url;
                        rVideos.Add(video);
                    }
                    var inputFile = new MediaFile { Filename = @"C:\Users\omerf\source\repos\KayaTS\UniCourses\UniCourses.WebUI\wwwroot" + video.VideoPath };
                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                    }
                    Lesson lesson = rLesson.GetBy(x => x.Id == video.LessonID);
                    lesson.Duration += (int)inputFile.Metadata.Duration.TotalSeconds;
                    rCourse.GetBy(x => x.Id == lesson.CourseID).Duration += lesson.Duration;
                    rCourse.Save();
                    rLesson.Update(lesson);
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR: " + ex.Message.ToString();
                }
            }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Cikis()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        [HttpGet]
        public IActionResult RegisterEducator(int id)
        {
            Member member = rMember.GetBy(x => x.ID == id);
            EducatorMemberVM educatorMemberVM = new EducatorMemberVM { Member = member };
            return View(educatorMemberVM);
        }
        [HttpPost]
        public IActionResult RegisterEducator(Educator ed)
        {
            rEducator.Add(ed);
            return RedirectToAction("Index");
        }
        public IActionResult Rolata(int id)
        {
            var d = rMember.Bul(id);
            d.RoleNumber = 2;
            rMember.Save();
            return RedirectToAction("RegisterEducator", new { id });
        }

    }
}
