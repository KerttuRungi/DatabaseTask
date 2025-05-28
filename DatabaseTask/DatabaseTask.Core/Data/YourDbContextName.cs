using System;
using System.Collections.Generic;
using DatabaseTask.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Core.Data;

public partial class YourDbContextName : DbContext
{
    public YourDbContextName()
    {
    }

    public YourDbContextName(DbContextOptions<YourDbContextName> options)
        : base(options)
    {
    }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<JobTitle> JobTitles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LENOVO;Database=DatabaseTaskDbContext;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>(entity =>
        {
            entity.Property(e => e.ChildId).HasColumnName("Child_ID");
            entity.Property(e => e.DateOfBirth).HasColumnName("Date_Of_Birth");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_Id");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.AccessId).HasColumnName("Access_ID");
            entity.Property(e => e.Department).HasDefaultValue("");
            entity.Property(e => e.Email).HasDefaultValue("");
            entity.Property(e => e.IdCode)
                .HasDefaultValue("")
                .HasColumnName("Id_Code");
            entity.Property(e => e.PhoneNumber)
                .HasDefaultValue("")
                .HasColumnName("Phone_Number");
        });

        modelBuilder.Entity<JobTitle>(entity =>
        {
            entity.ToTable("JobTitle");

            entity.Property(e => e.JobTitleId).HasColumnName("JobTitle_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
