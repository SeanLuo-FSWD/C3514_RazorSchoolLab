using System;
using Microsoft.EntityFrameworkCore;
using SchoolLibrary;

namespace SchoolAPI.data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>().HasData(
              new
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Tom",
                  LastName = "Day",
                  School = "Physics"
              }, new
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Ann",
                  LastName = "Fox",
                  School = "Geology"
              }, new
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Art",
                  LastName = "Ash",
                  School = "Nursing"
              }, new
              {
                  StudentId = Guid.NewGuid().ToString(),
                  FirstName = "Mia",
                  LastName = "Hay",
                  School = "Science"
              }
            );
        }
    }

}
