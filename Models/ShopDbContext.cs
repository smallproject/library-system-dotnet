using Microsoft.EntityFrameworkCore;

namespace library_system_dotnet.Models
{
    public class ShopDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");
        //}
    }
}
