using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
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
        Repository<CourseCategoryVM> rCourCat;
        MyContext myContext;
        public HomeController(Repository<Admin> _rAdmin, Repository<Educator> _rEducator, Repository<Category> _rcategory, Repository<Course> _rcourse, Repository<CourseCategoryVM> _rcourcat, Repository<Member> _rmember)
        {
            rAdmin = _rAdmin;
            rCategory = _rcategory;
            rMember = _rmember;
            rCourse = _rcourse;
            rCourCat = _rcourcat;
            rEducator = _rEducator;
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
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
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
        public IActionResult CourseSinglePage()
        {

            //List<Member> members = rMember.GetAll(x => x.Mail == email).ToList();
            
            //List<Member> members = rMember.GetAll(x => x.Mail == User.Claims.FirstOrDefault(f => f.Type == System.Security.Claims.ClaimTypes.Email).Value).ToList();
            return View(girisyapan);
        }
        
        public IActionResult Courses(int id)
        {
            List<Course> courses = rCourse.GetAll(x => x.Categoryi == id).ToList();
            List<Category> categories = rCategory.GetAll().ToList();
            CourseCategoryVM courcatVM = new CourseCategoryVM { Courses = courses, Categories = categories };
            //return View(rCourse.GetAll(x=>x.CategoryID == id).ToList(), rCategory.GetAll().ToList());
            return View(courcatVM);
        }
        


    }

}
