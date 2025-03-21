﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using AssignmentEf04.Context;
using AssignmentEf04.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AssignmentEf04.Context.Configurations
{
    public partial class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasOne(d => d.ReportsToNavigation).WithMany(p => p.InverseReportsToNavigation).HasConstraintName("FK_Employees_Employees");

            entity.HasMany(d => d.Territories).WithMany(p => p.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeTerritory",
                    r => r.HasOne<Territory>().WithMany()
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeeTerritories_Territories"),
                    l => l.HasOne<Employee>().WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeeTerritories_Employees"),
                    j =>
                    {
                        j.HasKey("EmployeeID", "TerritoryID").IsClustered(false);
                        j.ToTable("EmployeeTerritories");
                        j.IndexerProperty<string>("TerritoryID").HasMaxLength(20);
                    });

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Employee> entity);
    }
}
