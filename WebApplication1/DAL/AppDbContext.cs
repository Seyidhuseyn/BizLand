using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-0D6QJVK\\SQLEXPRESS;Database=BizLand;Trusted_Connection=True;Encrypt=false;");
        }
    }
}
