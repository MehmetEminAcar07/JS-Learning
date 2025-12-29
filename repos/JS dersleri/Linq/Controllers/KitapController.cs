using Linq.Models;
using Microsoft.AspNetCore.Mvc;

namespace Linq.Controllers
{
    public class KitapController : Controller
    {
        List<Kitap> Kitaplar = new List<Kitap>()
        {
             new Kitap() { KitapID = 1 ,KitapAdi = "Suç ve Ceza",YazarAdi = "Dostoyevksi",KitapSayfasi = 690 },
             new Kitap() { KitapID = 1 ,KitapAdi = "Karamazov  Kardeşler",YazarAdi = "Dostoyevksi",KitapSayfasi = 850 },
             new Kitap() { KitapID = 1 ,KitapAdi = "Martin Eden",YazarAdi = "Jack London",KitapSayfasi = 520 },
             new Kitap() { KitapID = 1 ,KitapAdi = "İki Şehrin Hikayesi",YazarAdi = "Charles Dickens",KitapSayfasi = 400 },
             new Kitap() { KitapID = 1 ,KitapAdi = "Satranç",YazarAdi = "Stefan Zweig",KitapSayfasi = 90 }
        };
        public IActionResult Index();
        public IActionResult TekKitapGoster();
        public string Goster();
        public string ErtelenmisSorgu();
        public string AnlikSorgu();
    }
}