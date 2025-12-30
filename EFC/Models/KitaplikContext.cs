using Microsoft.EntityFrameworkCore;

namespace EFC.Models
{
    public class KitaplikContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Kitaplik;Trusted_Connection=True;");
        }
    }
}
