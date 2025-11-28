using FullStackCRUD.Models;
using Microsoft.EntityFrameworkCore;


namespace FullStackCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Example: configure max length and default values if needed
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(100).IsRequired();
        }
    }
}