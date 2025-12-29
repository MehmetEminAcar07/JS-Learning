using EFC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFC.Controllers
{
    public class YazarController : Controller
    {
        public KitaplikContext k = new KitaplikContext();
        public IActionResult Index()
        {
            var m=k.Yazarlar.ToList();
            return View(m);
        }
        public IActionResult Create()
        {
            
            return View();
        }
    }
[HttpPost]
        public IActionResult Create(Yazar y)
        {
        if (ModelState.IsValid)
        {
            k.Add(y);
            k.SaveChanges();
            return RedirectToAction("index");
        }
        else
        {
            ViewBag.msj = "Yazar Eklenemedi!";
            return View(y);
        }
            
        return View;
        }

}

