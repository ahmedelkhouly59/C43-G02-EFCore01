using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORE_1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_1.DbContexts
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Server=.;Database=ITIDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet <Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet <Stud_Course> Stud_Courses { get; set; }

        public DbSet <Department> Departments { get; set; }

        public DbSet <Course_Inst> Course_Instrs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
            modelBuilder.Entity<Course_Inst>()
                .HasKey(sc => new { sc.Inst_ID, sc.Course_ID });
        }






    }
}
