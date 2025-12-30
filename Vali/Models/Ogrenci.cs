using System.ComponentModel.DataAnnotations;

namespace Vali.Models
{
    public class Ogrenci
    {
        [Required(ErrorMessage = "isim alanı boş bırakılamaz!")]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Cinsiyet Seçilmelidir!")]
        public string Cinsiyet { get; set; }

        [Range(1, 6, ErrorMessage = "Seçilen Sınıf 1-6 arasında olmalıdır!")]
        public int Sinif { get; set; }
    }
}
