using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.API.Models.Domain;

namespace StudentManagementSystem.API.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassName> ClassNames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.Email)
                .IsUnique();

            modelBuilder.Entity<Student>()
                .HasIndex(s => new { s.LastName, s.FirstName });

            modelBuilder.Entity<Student>()
                .HasIndex(s => s.ClassNameId);

            modelBuilder.Entity<Student>()
                .HasIndex(s => s.HomeDistrict);

            
            modelBuilder.Entity<ClassName>()
                .HasIndex(c => c.Name)
                .IsUnique();
        }
    }
}