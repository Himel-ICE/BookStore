using BookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Data
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 4, Name = "Action", DisplayOrder = 1},
                new Category { Id = 5, Name = "Scifi", DisplayOrder = 1 },
                new Category { Id = 6, Name = "History", DisplayOrder = 1 }
            );
        }
    }
}
