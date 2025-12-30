using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Vali.Models;

namespace Vali.Controllers
{
    public class Ogrenci : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle()
        {
            return View();
        }
        public IActionResult Kaydet(Models.Ogrenci ogr)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                ViewBag.Hata = "Öğrenci Ekleme Başarısız";
                return View("Hata");
            }
        }
    }
}
