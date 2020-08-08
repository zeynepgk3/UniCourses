using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UniCourses.Bl.Repositories;
using UniCourses.Dal.Entities;

namespace UniCourses.WebUI.ViewComponents
{
    public class AddToCartViewComponent : ViewComponent
    {
        Repository<Category> rCategory;
        Repository<Member> rMember;

        public AddToCartViewComponent(Repository<Member> _rMember, Repository<Category> _rcategory)
        {
            rCategory = _rcategory;
            rMember = _rMember;
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize]
        public IViewComponentResult Invoke(Cart cartObj)
        {
           /* cartObj.Id = 0;
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                ///cartObj.MemberId = claim.Value
                ///
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "id")); //Enum.GetName(typeof(ERole), ERole.uye))
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, Enum.GetName(typeof(ERole), ERole.egitmen))); //Enum.GetName(typeof(ERole), ERole.uye))
                                                                                                                 //claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"admin"));
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
                claimsPrincipal.AddIdentity(claimsIdentity);
                string uyeid = User.Claims.FirstOrDefault(f => f.Type == System.Security.Claims.ClaimTypes.Sid).Value;
                cartObj.MemberId = Convert.ToInt32(uyeid);

                Cart fromDb = rCart.GetBy(
                    s => s.MemberId == cartObj.MemberId
                    && s.CourseId == cartObj.CourseId
                    );
                if (fromDb == null)
                {
                    //insert
                    rCart.Update(cartObj);
                }
                else
                {
                    //update ekleme

                    fromDb.Count += cartObj.Count;
                }

                return RedirectToAction(nameof(Index));
            }
            else
            {
                var course = rCourse.GetBy(c => c.Id == cartObj.CourseId);

                Cart cart = new Cart()
                {
                    Course = course,
                    CourseId = course.Id
                };*/
               // return View(cart);
                return View();
            
        }
    }
}
