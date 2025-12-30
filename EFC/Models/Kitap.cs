using System.ComponentModel.DataAnnotations;

namespace EFC.Models
{
    public class Kitap
    {
        [Key]
        public int KitapID { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name ="Kitap Adı")]
        public string KitapAdi { get; set; }
        public int YazarID { get; set;}
        public Yazar Yazar { get; set; }
    }
}
