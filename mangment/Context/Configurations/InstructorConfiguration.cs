﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using mangment.Context;
using mangment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace mangment.Context.Configurations
{
    public partial class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> entity)
        {
            entity.HasOne(d => d.Department).WithMany(p => p.Instructors).OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Instructor> entity);
    }
}
