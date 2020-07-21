using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniCourses.WebUI.Models
{
    public class MemberLoginModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez")]
        public string UserName{ get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Password{ get; set; }
        public bool RememberME{ get; set; }
    }
}
