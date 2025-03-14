﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mangment.Models;

[Index("DepartmentId", Name = "IX_Courses_DepartmentId")]
[Index("InstructorId", Name = "IX_Courses_InstructorId")]
public partial class Course
{
    [Key]
    public int Id { get; set; }

    public int? Duration { get; set; }

    [StringLength(30)]
    public string? Name { get; set; }

    public int? InstructorId { get; set; }

    public int? DepartmentId { get; set; }

    [InverseProperty("Course")]
    public virtual ICollection<CouresSession> CouresSessions { get; set; } = new List<CouresSession>();

    [InverseProperty("Course")]
    public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new List<CourseStudent>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Courses")]
    public virtual Department? Department { get; set; }

    [ForeignKey("InstructorId")]
    [InverseProperty("Courses")]
    public virtual Instructor? Instructor { get; set; }

    public override string ToString()
    {
        return $"{Name}";
    }
}