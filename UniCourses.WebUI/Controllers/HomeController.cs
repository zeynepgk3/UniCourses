using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.Models;

namespace UniCourses.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<Member> _signInManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, SignInManager<Member> signInManager)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult Register()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            // Login sayfası
            
            return View(new MemberLoginModel());
        }
        [HttpPost]
        //public IActionResult Login(MemberLoginModel model)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        var SignInResult = _signInManager.PasswordSignInAsync(model.UserName, model.Password,model.RememberME, false).Result;
            
        //        if(SignInResult.Succeeded)
        //        {
        //            return RedirectToAction("", new { "Index", "Home" area = });
        //        }
        //        ModelState.AddModelError("Kullanıcı adı veya şifre hatalı");
        //    }
        //    return View(model);
        //}
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult CourseSinglePage()
        {
            return View();
        }
        [Route("/BeninGenericSayfam")]
        // [Route("/BeninGenericSayfam/{sayfaadi}")]

        public IActionResult Courses(/*string sayfaadi*/)
        {
            return View();
        }


    }
}
