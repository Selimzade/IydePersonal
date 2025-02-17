﻿using IydePersonal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IydePersonal.API.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
               .HasColumnName("Id");

            builder.Property(x => x.FullName)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnName("FullName");

            //builder.Property(x => x.LastName)
            //   .IsRequired()
            //   .HasMaxLength(100)
            //   .HasColumnName("Lastname");

            builder.Property(x => x.Gender)
               .IsRequired()
               .HasColumnName("Gender");

            builder.Property(x => x.DateOfBirth)
               .IsRequired()
               .HasColumnName("DateOfBirth");

            builder.Property(x => x.PhoneNumber)
               .IsRequired()
               .HasMaxLength(15)
               .HasColumnName("PhoneNumber");

            builder.Property(x => x.WorkPosition)
               .IsRequired()
               .HasColumnName("WorkPosition");

            builder.Property(x => x.IsActive)
               .IsRequired()
               .HasColumnName("IsActive");

            builder.Property(x => x.FixSalary)
               .IsRequired()
               .HasColumnName("FixSalary");

            builder.Property(x => x.StartWork)
               .IsRequired()
               .HasColumnName("StartWork");

            builder.Property(x => x.FinishWork)
               .HasColumnName("FinishWork");

            builder.Property(x => x.UserId)
                .IsRequired()
                .HasColumnName("UserId");
                
            //builder.Property(x=>x.StoreId)
            //    .IsRequired()
            //    .HasColumnName ("StoreId");

            //builder.HasData(new Employee
            //{
             
            //    FirstName = "Ehmed",
            //    LastName = "Mustafa",
            //    Gender = Gender.Male,
            //    DateOfBirth = DateTime.Parse("17.10.1987"),
            //    PhoneNumber = "502330644",
            //    WorkPosition = WorkPosition.Accountant,
            //    IsActive = true,
            //    FixSalary = 1000,
            //    Adress="Baki",
            //    StoreId = 1,
            //    StartWork = DateTime.Parse("10.10.2021"),   
               
            //});
        }
    }
}
