using Microsoft.AspNetCore.Mvc;
using SessionCookieExample.Models;
using System.Diagnostics;

namespace SessionCookieExample.Controllers
{
    public class HomeController : Controller
    {
        static List<User> Users = new List<User>()
        {
            new User(){UserName="Mehmet",UserPass="65",UserColor="Blue"},
            new User(){UserName="Ipek",UserPass="78",UserColor="Pink"},
        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User usr)
        {
            foreach (var item in Users) 
            {
                if (item.UserName == usr.UserName && item.UserPass == usr.UserPass)
                {
                    HttpContext.Session.SetString("SessionUser", item.UserName);
                    var cookop = new CookieOptions
                    {
                        Expires = DateTime.Now.AddSeconds(50)
                    };
                    HttpContext.Response.Cookies.Append("UserColor",item.UserColor,cookop);
                    return View("Giris");
                }
            }
            return View("Index");
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
    }
}
