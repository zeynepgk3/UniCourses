﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
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
        MyContext myContext;
        public HomeController(Repository<Videos> _rVideos, IWebHostEnvironment environment, MyContext _myContext, Repository<Category> _rCategory, Repository<Exam> _rExam, Repository<Educator> _rEducator, Repository<Lesson> _rLesson, Repository<Member> _rMember, Repository<Admin> _rAdmin, Repository<Course> _rCourse, Repository<CourseCategoryVM> _rCourCat)
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
        [HttpGet, Route("/EgitmenKayit")]
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
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educator = rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));
            course.EducatorID = educator.ID;
            rCourse.Add(course);
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
                    string url = @"\video\" + userName + @"\" + file.FileName;
                    string pathString = Path.Combine(folder, userName);
                    if (!Directory.Exists(pathString))
                    {
                        Directory.CreateDirectory(pathString);
                    }
                    var filePath = Path.Combine(pathString, file.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        // rVideos.Add(new Videos(video.Name, DateTime.Now, url, video.LessonID));
                        video.Name = userName;
                        video.LessonID = lesson.Id;
                        video.UploadDate = DateTime.Now;
                        video.VideoPath = url;
                        rVideos.Add(video);

                    }
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
        public IActionResult UploadVideo()
        {
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
            Educator educ = rEducator.GetBy(x => x.MemberID == Convert.ToInt32(uyeid));
            List<Educator> educator = myContext.Educator.Include(x => x.Courses).ToList();
            
            List<Course> courses = myContext.Course.Where(x=>x.EducatorID == educ.ID).Include(x => x.Lessons).ToList();
            //ViewBag.dgr = rLesson.GetAll(x => x. == dersin.).Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() });
            return View(courses);
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
                    string url = @"\video\" + userName + @"\" + file.FileName;
                    string pathString = Path.Combine(folder, userName);
                    if (!Directory.Exists(pathString))
                    {
                        Directory.CreateDirectory(pathString);
                    }
                    var filePath = Path.Combine(pathString, file.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        // rVideos.Add(new Videos(video.Name, DateTime.Now, url, video.LessonID));
                        video.Name = userName;
                        video.UploadDate = DateTime.Now;
                        video.VideoPath = url;
                        rVideos.Add(video);
                        
                    }
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
            return RedirectToAction("UploadVideo");
        }

    }
}
