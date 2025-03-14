﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mangment.Models;

[Index("DepartmentId", Name = "IX_Instructors_DepartmentId")]
public partial class Instructor
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    public string? LName { get; set; }

    [StringLength(255)]
    public string? FName { get; set; }

    [StringLength(255)]
    public string? Phone { get; set; }

    public int DepartmentId { get; set; }

    [InverseProperty("Instructor")]
    public virtual ICollection<CouresSession> CouresSessions { get; set; } = new List<CouresSession>();

    [InverseProperty("Instructor")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Instructors")]
    public virtual Department Department { get; set; } = null!;

    [InverseProperty("Manger")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [NotMapped] // EF Core should ignore this in the database
    public string FullName => $"{FName} {LName}";

    public override string ToString()
    {
        return $"{FullName}";
    }
}