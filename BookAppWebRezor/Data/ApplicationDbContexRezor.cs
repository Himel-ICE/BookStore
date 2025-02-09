using BookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAppWebRezor.Data
{
    public class ApplicationDbContexRezor : DbContext
    {
        public ApplicationDbContexRezor(DbContextOptions<ApplicationDbContexRezor> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 4, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 5, Name = "Scifi", DisplayOrder = 1 },
                new Category { Id = 6, Name = "History", DisplayOrder = 1 }
            );
        }
    }
}
