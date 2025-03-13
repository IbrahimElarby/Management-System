﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using mangment.Context.Configurations;
using mangment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
#nullable enable

namespace mangment.Context;

public partial class EFITIContext : DbContext
{
    public EFITIContext()
    {
    }

    public EFITIContext(DbContextOptions<EFITIContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CouresSession> CouresSessions { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseSessionAttandance> CourseSessionAttandances { get; set; }

    public virtual DbSet<CourseStudent> CourseStudents { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<daily_transaction> daily_transactions { get; set; }

    public virtual DbSet<last_transaction> last_transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ALBADR-LAPTOP\\MSSQLSERVER01;Database=EFITI;Trusted_Connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.InstructorConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.daily_transactionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.last_transactionConfiguration());

        OnModelCreatingGeneratedFunctions(modelBuilder);
        OnModelCreatingPartial(modelBuilder);

        modelBuilder.Ignore<Font>();
        modelBuilder.Ignore<Cursor>();
        modelBuilder.Ignore<ImageListStreamer>();

        modelBuilder.Ignore<Image>();
        modelBuilder.Ignore<Control>();
        modelBuilder.Ignore<ContextMenuStrip>();
     
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
