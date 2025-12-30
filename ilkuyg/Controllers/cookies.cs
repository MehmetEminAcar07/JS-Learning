using ilkuyg.Models;
using Microsoft.AspNetCore.Mvc;

namespace ilkuyg.Controllers
{
    public class cookies : Controller
    {
        static List<User> users = new List<User>() 
        {
            new User() {UserName= "mehmet",UserPass="65",UserColor="Blue" },
            new User() { UserName= "ipek",UserPass= "78",UserColor= "Pink" },
        };
            

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User usr)
        {
            foreach (var item in users) {
            if(item.UserName==usr.UserName && item.UserPass==usr.UserPass)
                {
                    HttpContext.Session.SetString("SessionUser", item.UserName);
                    var cookop = new CookieOptions
                    {
                        Expires = DateTime.Now.AddSeconds(50)
                    };
                    HttpContext.Response.Cookies.Append("UserColor", item.UserColor, cookop);
                    return View("Giris");
                }
            }
            return View("Index");
        }
    }
}
