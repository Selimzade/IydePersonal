﻿// <auto-generated />
using System;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IydePersonal.Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240327144059_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IydePersonal.Core.Entities.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FinishWork")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartWork")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WorkPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("SalaryId");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.EmployeePunkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("PunktId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PunktId");

                    b.ToTable("EmployeePunkt");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.Punkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Punkts");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Award")
                        .HasColumnType("int");

                    b.Property<int>("Conclusion")
                        .HasColumnType("int");

                    b.Property<int>("Countingdown")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Generalcheck")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Penalty")
                        .HasColumnType("int");

                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.Property<decimal>("StorePercent")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.Employee", b =>
                {
                    b.HasOne("IydePersonal.Core.Entities.Salary", "Salary")
                        .WithMany("employees")
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IydePersonal.Core.Entities.User", "Users")
                        .WithMany("employees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salary");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.EmployeePunkt", b =>
                {
                    b.HasOne("IydePersonal.Core.Entities.Employee", "employees")
                        .WithMany("employeePunkts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IydePersonal.Core.Entities.Punkt", "punkts")
                        .WithMany("employeePunkts")
                        .HasForeignKey("PunktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employees");

                    b.Navigation("punkts");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.Employee", b =>
                {
                    b.Navigation("employeePunkts");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.Punkt", b =>
                {
                    b.Navigation("employeePunkts");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.Salary", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("IydePersonal.Core.Entities.User", b =>
                {
                    b.Navigation("employees");
                });
#pragma warning restore 612, 618
        }
    }
}