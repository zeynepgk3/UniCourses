using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Entities;
using UniCourses.WebUI.ViewModels;

namespace UniCourses.WebUI.Areas.uye.Controllers
{
    [Area("uye"), Authorize(Roles = "uye")]
    public class CartController : Controller
    {
        Repository<Cart> rCart;
        Repository<Member> rMember;
        Repository<Course> rCourse;
        Repository<CourseMember> rCourseMember;
        Repository<Order> rOrder;
        Repository<Educator> rEducator;
        // private readonly UserManager<IdentityUser> userManager;
        public CartVM CartVM { get; set; }
        public CartController(Repository<CourseMember> _rCourseMember, Repository<Educator> _rEducator, Repository<Course> _rCourse, Repository<Order> _rOrder, Repository<Member> _rMember,/*UserManager<IdentityUser> _userManager,*/ Repository<Cart> _rCart)
        {
            //  userManager = _userManager;
            rCart = _rCart;
            rCourseMember = _rCourseMember;
            rOrder = _rOrder;
            rMember = _rMember;
            rCourse = _rCourse;
            rEducator = _rEducator;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);


            claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "id")); //Enum.GetName(typeof(ERole), ERole.uye))
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.egitmen))); //Enum.GetName(typeof(ERole), ERole.uye))
                                                                                                             //claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"admin"));
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            claimsPrincipal.AddIdentity(claimsIdentity);
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == System.Security.Claims.ClaimTypes.Sid).Value;

            var fromClaim = Convert.ToInt32(uyeid);

            // BURASINI KONTROL ET!!
            //  int fromClaim = (int)Convert.ToUInt32(claims.Value);
            CartVM = new CartVM()
            {
                Order = new Order(),
                ListCart = rCart.GetAllLazy(u => u.MemberId == fromClaim, includeProperties: "Course").ToList()
            };
            CartVM.Order.OrderTotal = 0;
            //int frmV = Convert.ToInt32(claims.Value)
            CartVM.Order.member = rMember.GetBy(u => u.ID == fromClaim);

            foreach (var cart in CartVM.ListCart)
            {
                //Eklenecek 
                cart.Price = GetPriceBaseOnQuantity(cart.Course);
                CartVM.Order.OrderTotal += cart.Price;
                cart.Course.Description = ConvertToRawHtml(cart.Course.Description);

                if (cart.Course.Description.Length > 50)
                {
                    cart.Course.Description = cart.Course.Description.Substring(0, 49) + "...";
                }
            }

            return View(CartVM);
        }
      
        public IActionResult RemoveFromCart(int courseId)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "id"));
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == System.Security.Claims.ClaimTypes.Sid).Value;


            var selectedCourse = rCart.GetBy(x => x.CourseId == courseId && x.MemberId == Convert.ToInt32(uyeid));

            if (selectedCourse == null)
            {
                return NotFound();
            }
            selectedCourse.Count = 0;
            rCart.Remove(selectedCourse);
            return RedirectToAction("Index");
        }

        public IActionResult Summary(CartVM CartVM)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "id"));

            //claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "id")); //Enum.GetName(typeof(ERole), ERole.uye))
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.egitmen))); //Enum.GetName(typeof(ERole), ERole.uye))
                                                                                                             //claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"admin"));
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            claimsPrincipal.AddIdentity(claimsIdentity);
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == System.Security.Claims.ClaimTypes.Sid).Value;

            var fromClaim = Convert.ToInt32(uyeid);

            CartVM = new CartVM()
            {
                Order = new Order(),
                ListCart = rCart.GetAllLazy(u => u.MemberId == fromClaim, includeProperties: "Course").ToList()

            };
            Member girenuye = rMember.GetBy(f => f.ID == fromClaim);
            CartVM.Order.member = rMember.GetBy(u => u.ID == fromClaim);
            CartVM.Order.MemberId = girenuye.ID;

            foreach (var item in CartVM.ListCart)
            {
                item.Price = GetPriceBaseOnQuantity(item.Course);
                CartVM.Order.OrderTotal += item.Price;
            }
            // tc sini al.
            return View(CartVM);
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        [ActionName("Summary")]
        public IActionResult SummaryPost(CartVM CartVM)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "id"));

            //claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "id")); //Enum.GetName(typeof(ERole), ERole.uye))
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.egitmen))); //Enum.GetName(typeof(ERole), ERole.uye))
                                                                                                             //claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"admin"));
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            claimsPrincipal.AddIdentity(claimsIdentity);
            string uyeid = User.Claims.FirstOrDefault(f => f.Type == System.Security.Claims.ClaimTypes.Sid).Value;

            var fromClaim = Convert.ToInt32(uyeid);

            CartVM = new CartVM()
            {
                Order = new Order(),
                ListCart = rCart.GetAllLazy(u => u.MemberId == fromClaim, includeProperties: "Course").ToList()

            };

            Member girenuye = rMember.GetBy(f => f.ID == fromClaim);
            CartVM.Order.member = rMember.GetBy(u => u.ID == fromClaim);
            CartVM.Order.MemberId = girenuye.ID;

            foreach (var item in CartVM.ListCart)
            {
                item.Price = GetPriceBaseOnQuantity(item.Course);
                CartVM.Order.OrderTotal += item.Price;
                //Yeni Eklendiler------------------------
                CourseMember CourseMember;
                CourseMember = new CourseMember()
                {
                    Member = girenuye,
                    MemberId = girenuye.ID,
                    Course = item.Course,
                    CourseId = item.CourseId

                };
                rCourse.GetBy(x => x.Id == item.CourseId).NumberOfStudent++;
                rEducator.GetBy(x => x.ID == item.Course.EducatorID).TotalStudent++;
                rCourse.Save();
                rEducator.Save();
                rCourseMember.Add(CourseMember);
                //---------------------------------------
            }
            CartVM.ListCart = rCart.GetAllLazy(s => s.MemberId == fromClaim, includeProperties: "Course");

            CartVM.Order.MemberId = fromClaim;

            CartVM.Order.RecDate = DateTime.Now;

            rOrder.Add(CartVM.Order);
            rOrder.Save();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var item in CartVM.ListCart)
            {
                item.Price = GetPriceBaseOnQuantity(item.Course);

                OrderDetail oDetails = new OrderDetail()
                {
                    CourseId = item.CourseId,
                    OrderId = CartVM.Order.Id,

                    Count = 1
                };
                CartVM.Order.OrderTotal = item.Course.Price;

            }

            rCart.RemoveRange(CartVM.ListCart);
            rCart.Save();

            return RedirectToAction("OrderConfirmation", "Cart", new { id = CartVM.Order.CourseId });

        }
        public IActionResult OrderConfirmation(int id)
        {
            
            return View(id);
        }
        private static string ConvertToRawHtml(string description)
        {
            char[] array = new char[description.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < description.Length; i++)
            {
                char let = description[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }

            return new string(array, 0, arrayIndex);
        }
        private static double GetPriceBaseOnQuantity(Course course)
        {
            return course.Price;
        }
    }
}
