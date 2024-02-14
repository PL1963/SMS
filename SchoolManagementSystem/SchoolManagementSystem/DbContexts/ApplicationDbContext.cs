using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models.StdentModel;
using System.Collections.Generic;

namespace SchoolManagementSystem.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<UserLogin> LoginCredentials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogin>().HasNoKey();           

            base.OnModelCreating(modelBuilder);
        }
    }
}
