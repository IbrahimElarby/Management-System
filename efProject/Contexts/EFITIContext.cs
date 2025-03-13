using efProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProject.Contexts
{
    public class EFITIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ALBADR-LAPTOP\\MSSQLSERVER01;DataBase=EFITI;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseStudent>().HasKey(cs => new {cs.StudentId, cs.CourseId});
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>()
       .HasOne(i => i.Department)
       .WithMany(d => d.Instructors)
       .HasForeignKey(i => i.DepartmentId)
       .OnDelete(DeleteBehavior.Restrict); // Prevents cascade delete issues

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)  // Self-reference for Manager
                .WithMany()
                .HasForeignKey(d => d.MangerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        public override int SaveChanges()
        {
            var entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added
                               || e.State == EntityState.Modified
                           select e.Entity;
            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(entity, validationContext, true);
            }
            // Keep
            return base.SaveChanges();
        }
            public virtual DbSet<Student> Students { get; set; }

        public virtual  DbSet<Department> Departments { get; set; }

        public virtual DbSet<Instructor> Instructors { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<CouresSession> CouresSessions { get; set; }

        public virtual DbSet<CourseSessionAttandance> CourseSessionAttandances { get; set; }

        public virtual DbSet<CourseStudent> CourseStudents { get; set; }
    }
}
