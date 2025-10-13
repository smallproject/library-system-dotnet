using library_system_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace library_system_dotnet.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration can go here
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired();
        }
    }
}
