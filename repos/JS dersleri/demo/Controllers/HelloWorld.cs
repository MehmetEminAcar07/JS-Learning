using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace demo.Controllers
{
    public class HelloWorld : Controller
    {
        
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}

