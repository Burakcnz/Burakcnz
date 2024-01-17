using BookApp.Models.Configs;
using BookApp.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Models.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            //Dependency Injection
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new BookCategoryConfig());


            base.OnModelCreating(modelBuilder);
        }

    }
}
