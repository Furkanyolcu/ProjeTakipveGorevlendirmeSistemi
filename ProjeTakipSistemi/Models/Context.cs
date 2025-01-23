using Microsoft.EntityFrameworkCore;
using ProjeTakipSistemi.Models.GorevAtama;
using ProjeTakipSistemi.Models.Personel;

namespace ProjeTakipSistemi.Models.DBContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8EQ0RI8\\SQLEXPRESS; database=ProjeTakipDB; integrated security=true; TrustServerCertificate=true");
        }
        public DbSet<PersonelBilgileri> PersonelBilgileris { get; set; }
        public DbSet<PersonelProjeleri> PersonelProjeleris { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
