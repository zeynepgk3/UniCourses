using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Contexts;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.Models;
using UniCourses.WebUI.ViewModels;

namespace UniCourses.WebUI.Controllers
{

    public class HomeController : Controller
    {
        Repository<Category> rCategory;
        Repository<Member> rMember;
        Repository<Admin> rAdmin;
        Repository<Educator> rEducator;
        Repository<Course> rCourse;
        Repository<Cart> rCart;
        Repository<CourseCategoryVM> rCourCat;
        Repository<Lesson> rLesson;
        Repository<Videos> rVideos;
        Repository<CourseMember> rCourseMember;
        IWebHostEnvironment _environment;
        MyContext myContext;

        public HomeController(Repository<Videos> _rVideos, Repository<CourseMember> _rCourseMember, IWebHostEnvironment environment, Repository<Admin> _rAdmin, MyContext _myContext, Repository<Lesson> _rLesson, Repository<Cart> _rCart, Repository<Educator> _rEducator, Repository<Category> _rcategory, Repository<Course> _rcourse, Repository<CourseCategoryVM> _rcourcat, Repository<Member> _rmember)
        {
            rAdmin = _rAdmin;
            rCategory = _rcategory;
            rMember = _rmember;
            rCourse = _rcourse;
            rCourCat = _rcourcat;
            rEducator = _rEducator;
            rCart = _rCart;
            rLesson = _rLesson;
            myContext = _myContext;
            _environment = environment;
            rCourseMember = _rCourseMember;
            rVideos = _rVideos;


        }
        public IActionResult Index()
        {
            var user = User;
            return View(rCategory.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet, Route("/UyeKayit")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost, Route("/UyeKayit")]
        public async Task<IActionResult> RegisterAsync(Member m)
        {
            rMember.Add(m);

            ClaimsIdentity claimsIdentity = new ClaimsIdentity("UniCourses");
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, m.ID.ToString()));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, m.NameSurName));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Email, m.Mail));
            Member girenuye = rMember.GetBy(f => f.ID == m.ID);

            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "uye")); //Enum.GetName(typeof(ERole), ERole.uye))
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.egitmen))); //Enum.GetName(typeof(ERole), ERole.uye))
                                                                                                             //claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"admin"));
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            claimsPrincipal.AddIdentity(claimsIdentity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsPrincipal), new AuthenticationProperties() { IsPersistent = true });
            return RedirectToAction("Index", "Home", new { area = "uye" });
        }

        [Route("/giris")]
        public IActionResult Uye(string ReturnUrl)
        {
            // Login sayfası
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        //static string uyemail;
        static Member girisyapan;
        //public Member uye;
        [HttpPost, Route("/giris")]
        public async Task<IActionResult> Uye(Member member, string ReturnUrl)
        {
            if (!string.IsNullOrEmpty(ReturnUrl) && ReturnUrl.Contains("panel"))
            {
                Admin admin = rAdmin.GetBy(a => a.Mail == member.Mail && a.Password == member.Password) ?? null;

                if (admin != null)
                {
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity("adminIdentity");
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, admin.Mail));
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.admin)));
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
                    claimsPrincipal.AddIdentity(claimsIdentity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsPrincipal), new AuthenticationProperties() { IsPersistent = true });
                    return RedirectToAction("Index", "Home", new { area = "panel" });
                }
                else
                {
                    ViewBag.Hata = "Admin adı veya Şifre Hatalı";
                    return View();
                }

            }
            //if (!string.IsNullOrEmpty(ReturnUrl) && ReturnUrl.Contains("uye"))

            Member uye = rMember.GetBy(f => f.Mail == member.Mail && f.Password == member.Password) ?? null;
            if (uye != null)
            {
                ClaimsIdentity claimsIdentity = new ClaimsIdentity("UniCourses");
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, uye.ID.ToString()));
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, uye.NameSurName));
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Email, uye.Mail));
                Member girenuye = rMember.GetBy(f => f.ID == uye.ID);
                //uyemail = member.Mail;
                girisyapan = rMember.GetBy(x => x.Mail == member.Mail);

                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "uye")); //Enum.GetName(typeof(ERole), ERole.uye))
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.egitmen))); //Enum.GetName(typeof(ERole), ERole.uye))
                                                                                                                 //claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"admin"));
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
                claimsPrincipal.AddIdentity(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsPrincipal), new AuthenticationProperties() { IsPersistent = true });
                return RedirectToAction("Index", "Home", new { area = "uye" });
            }
            else
            {
                ViewBag.Hata = "Kullanıcı adı veya Şifre Hatalı";
                return View();
            }


            /*if (!string.IsNullOrEmpty(ReturnUrl) && ReturnUrl.Contains("educator"))
            {
                Educator educator = rEducator.GetBy(e => e.Mail == member.Mail && e.Password == member.Password) ?? null;
                if (educator != null)
                {
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity("firstIdentity");
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, educator.Mail));
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.egitmen)));
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
                    claimsPrincipal.AddIdentity(claimsIdentity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsPrincipal), new AuthenticationProperties() { IsPersistent = true });
                    return RedirectToAction("Index", "Home", new { area = "educators" });
                }
                else
                {
                    ViewBag.Hata = "Egitmen adı veya Şifre Hatalı";
                    return View();
                }
            }*/
            ViewBag.Hata = "Kullanıcı adı veya Şifre Hatalı";
            return View();
        }

        [Route("/cikis")]
        public IActionResult Logout()
        {
            // Login sayfası
            return View();
        }
        public async Task<IActionResult> AccessDenied()
        {
            if (HttpContext.User.Identity.IsAuthenticated) await HttpContext.SignOutAsync();
            return Redirect("/giris");
        }
        /* public IActionResult GoogleLogin(string ReturnUrl)
         {
             string RedirectUrl = Url.Action("ExternalResponse", "Home", new { ReturnUrl = ReturnUrl });
             var properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", "/");

             return new ChallengeResult("Google", properties);
         }*/

        public IActionResult AboutUs()
        {

            return View();
        }
        [Route("/Kurslar/{name?}/{id?}")]
        public IActionResult Courses(int id, string name)
        {
            //List<Course> lastCourse = new List<Course>();
            List<Course> courses = new List<Course>();
            List<Category> categories = myContext.Category.Include(x => x.SubCategories).ToList();
            if (User.Identity.IsAuthenticated) {
                string uyeid = User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value;
                List<CourseMember> courseMembers = rCourseMember.GetAll(x => x.MemberId == Convert.ToInt32(uyeid)).ToList();
                List<int> courseInt = new List<int>();

                foreach (Course item in rCourse.GetAll(x => x.CategoryID == id).ToList())
                {
                    courseInt.Add(item.Id);
                }

                List<int> courseMemberInt = new List<int>();
                foreach (CourseMember item in courseMembers)
                {
                    courseMemberInt.Add((int)item.CourseId);
                }
                IEnumerable<int> fark = new List<int>();
                fark = courseInt.Except(courseMemberInt);
                

                foreach (var item in fark)
                {
                    courses.Add(rCourse.GetBy(x => x.Id == item));
                }
            }
            else
            {
                courses = rCourse.GetAll(x => x.CategoryID == id).ToList();
            }
            
           
            Category category = rCategory.GetBy(x => x.Id == id);
            List<Category> Subcategories = null;
            if (category.ParentID == null)
            {
                Subcategories = myContext.Category.Include(x => x.SubCategories).Include(x => x.Courses).ToList();
            }



            CourseCategoryVM courcatVM = new CourseCategoryVM
            {
                Courses = courses,
                Category = category,
                Categories = categories,
                Scategories = Subcategories

            };
            return View(courcatVM);
        }
        [Route("/{catname?}/{courname}/{id}")]
        public IActionResult CourseSinglePage(int id, string courname)
        {
            if (courname != "images")
            {
                var course = rCourse.GetBy(c => c.Id == id);
                Cart cart = null;
                CourseMember courseMember = new CourseMember();
                if (User.Identity.IsAuthenticated) // Sepete ekle
                {
                    int uyeid = Convert.ToInt32(User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Sid).Value);
                    cart = rCart.GetBy(
                        x => x.MemberId == uyeid
                        && x.CourseId == id);

                    courseMember = rCourseMember.GetBy(
                        x => x.MemberId == uyeid
                        && x.CourseId == id);
                }
                Course courses = rCourse.GetBy(x => x.Id == id);
                int educatid = courses.EducatorID;
                Educator educators = rEducator.GetBy(x => x.ID == educatid);
                List<Lesson> lesson = rLesson.GetAll(x => x.CourseID == id).ToList();
                //Image getir
                Image img = myContext.Images.FirstOrDefault(i => i.CourseID == courses.Id);
                LessonCoursesVM lessonCourses = new LessonCoursesVM { Lessons = lesson, Courses = courses, Educator = educators, Cart = cart, courseMember = courseMember };
                return View(lessonCourses);
            }
            else return View();
        }

    }

}
