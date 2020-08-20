using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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
using X.PagedList;
using UniCourses.WebUI.Utility;

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
        Repository<Picture> rPicture;
        Repository<Videos> rVideos;
        Repository<CourseMember> rCourseMember;
        Repository<Tag> rTag;
        IWebHostEnvironment _environment;
        MyContext myContext;

        public HomeController(Repository<Videos> _rVideos, Repository<Tag> _rTag, Repository<Picture> _rPicture, Repository<CourseMember> _rCourseMember, IWebHostEnvironment environment, Repository<Admin> _rAdmin, MyContext _myContext, Repository<Lesson> _rLesson, Repository<Cart> _rCart, Repository<Educator> _rEducator, Repository<Category> _rcategory, Repository<Course> _rcourse, Repository<CourseCategoryVM> _rcourcat, Repository<Member> _rmember)
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
            rPicture = _rPicture;
            rTag = _rTag;
        }
        public IActionResult Index(string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return RedirectToAction("SearchPage", new { search });
            }
            var user = User;
            CourseCategoryVM courseCategoryVM = new CourseCategoryVM
            {
                Courses = rCourse.GetAll().OrderByDescending(s => s.Score).ToList(),
                Categories = rCategory.GetAll().ToList(),
                Educators = rEducator.GetAll().ToList(),
                Members = rMember.GetAll().ToList()
            };
            return View(courseCategoryVM);
        }
        public IActionResult SearchPage(string search, int? page)
        {
            ViewBag.pageNumber = page;
            List<Course> foundCourse = rCourse.GetAll(x => x.Name.Contains(search)).ToList();
            return View(foundCourse);
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
            Picture img = new Picture();
            img.ImageTitle = "Member-Default-Picture.png";
            img.ImageData = "Member-Default-Picture.png";
            m.PictureURL= "Member-Default-Picture.png";
            rMember.Save();
            img.MemberID = m.ID;
            rPicture.Add(img);
            m.PictureID = img.Id;
            rMember.Update(m);
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
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.uye)));
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
        public IActionResult UyeGoruntule(int id)
        {
            return View(rMember.GetBy(r => r.ID == id));
        }
        public IActionResult EgitimciGoruntule(int id)
        {
            return View(rEducator.GetBy(r => r.ID == id));
        }
        public IActionResult AboutUs()
        {

            return View();
        }
        [Route("/Kurslar/{name?}/{id?}/{page?}")]
        public IActionResult CoursesSort(int id, string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Score" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.catid = id;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            List<Course> courses = new List<Course>();
            if (User.Identity.IsAuthenticated && User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Role).Value == "uye")
            {
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
                    Course c = myContext.Course.FirstOrDefault(x => x.Id == item && x.State == true);
                    if (c != null)
                    {
                        courses.Add(c);
                    }
                }
            }
            else
            {
                courses = rCourse.GetAll(x => x.CategoryID == id).ToList();
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper())
                                       || s.Title.ToUpper().Contains(searchString.ToUpper()) || s.Description.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            switch (sortOrder)
            {
                case "Score":
                    courses = courses.OrderByDescending(s => s.Score).ToList();//En çok Puan
                    break;
                case "Student":
                    courses = courses.OrderByDescending(s => s.NumberOfStudent).ToList();//En çok öğrenci
                    break;
                case "Date":
                    courses = courses.OrderBy(s => s.Duration).ToList(); // En yeni
                    break;
                case "date_desc":
                    courses = courses.OrderByDescending(s => s.Duration).ToList();// En eski
                    break;
                default:
                    courses = courses.OrderBy(s => s.Name).ToList();//İsim
                    break;
            }
            int pageSize = 2;
            ViewBag.dgr = pageNumber;
            
            CourseCategoryVM courcat = new CourseCategoryVM() {
                CourseList = PaginatedList<Course>.Create(courses, pageNumber ?? 1, pageSize),
                Tags = rTag.GetAll(x=>x.CategoryId == id).ToList()
            };
            return View(courcat);
        }
        
        public IActionResult Courses(int id, string sortOrder, int? page)
        {
            //List<Course> lastCourse = new List<Course>();
            List<Course> courses = new List<Course>();
            List<Category> categories = myContext.Category.Include(x => x.SubCategories).ToList();
            if (User.Identity.IsAuthenticated && User.Claims.FirstOrDefault(f => f.Type == ClaimTypes.Role).Value == "uye") {
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
                    Course c = rCourse.GetBy(x => x.Id == item && x.State == true);
                    if (c != null)
                    {
                        courses.Add(c);
                    }
                }
            }
            else
            {
                courses = rCourse.GetAll(x => x.CategoryID == id && x.State == true).ToList();
            }
            
            Category category = rCategory.GetBy(x => x.Id == id);
            List<Category> Subcategories = null;
            if (category.ParentID == null)
            {
                Subcategories = myContext.Category.Include(x => x.SubCategories).Include(x => x.Courses).ToList();
            }
            //pagination
            var pageNumber = page ?? 1;
            int pageSize = 2;
            ViewBag.dgr = pageNumber;
            IEnumerable<Course> onePage = courses.ToPagedList(pageNumber, pageSize);
            pageSize = (int)Math.Ceiling(courses.Count / (double)pageSize);


            CourseCategoryVM courcatVM = new CourseCategoryVM
            {
                CoursesPage = onePage,
                PageSize = pageSize,
                Pagenumber = pageNumber,
                Courses = courses,
                Category = category,
                Categories = categories,
                Scategories = Subcategories

            };
            return View(courcatVM);
        }
        [Route("/Detay/{catname}/{courname}/{id}")]
        public IActionResult CourseSinglePage(int id)
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
                int? educatid = courses.EducatorID;
                Educator educators = rEducator.GetBy(x => x.ID == educatid);
                List<Lesson> lesson = rLesson.GetAllLazy(x => x.CourseID == id, includeProperties : "Videos").ToList();
                //Image getir
                Image img = myContext.Images.FirstOrDefault(i => i.CourseID == courses.Id);
                LessonCoursesVM lessonCourses = new LessonCoursesVM { Lessons = lesson, Courses = courses, Educator = educators, Cart = cart, courseMember = courseMember };
                return View(lessonCourses);
        }

    }

}
