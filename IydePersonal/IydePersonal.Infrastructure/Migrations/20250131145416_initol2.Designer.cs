﻿// <auto-generated />
using System;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250131145416_initol2")]
    partial class initol2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "1",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "2",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "3",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3b1c830e-ab69-47c1-b2ab-59df44682109",
                            Email = "Prince.1987@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Ehmed",
                            LastName = "Mustafa",
                            LockoutEnabled = false,
                            NormalizedEmail = "PRINCE.1987@MAIL.RU",
                            NormalizedUserName = "EHMED MUSTAFA",
                            PasswordHash = "AQAAAAIAAYagAAAAEExEe7T/0a4skJ9mjq/LTjIgGYU59Ek8n924EbyDSgh40KamN9hAuprGPtkSrFq/LA==",
                            PhoneNumber = "+994502330644",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1",
                            TwoFactorEnabled = false,
                            UserName = "Ehmed Mustafa"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d08fe839-6c84-4f26-bc91-e53add16ef40",
                            Email = "Prince.1987@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Omer",
                            LastName = "Mustafa",
                            LockoutEnabled = false,
                            NormalizedEmail = "PRINCE.1987@MAIL.RU",
                            NormalizedUserName = "OMER MUSTAFA",
                            PasswordHash = "AQAAAAIAAYagAAAAEHyern8KcjuCaJN6hCVfBBqtp27BiXiOOQ574KifOCNiqHgzyL2ZPM056G0LEH9kaw==",
                            PhoneNumber = "+994502330644",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2",
                            TwoFactorEnabled = false,
                            UserName = "Omer Mustafa"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "169d4e82-ef6f-4a6a-b7bb-4a58757c8467",
                            Email = "Prince.1987@mail.ru",
                            EmailConfirmed = false,
                            FirstName = "Axmed",
                            LastName = "Mustafa",
                            LockoutEnabled = false,
                            NormalizedEmail = "PRINCE.1987@MAIL.RU",
                            NormalizedUserName = "AXMED MUSTAFA",
                            PasswordHash = "AQAAAAIAAYagAAAAEIUtbY0El/qteBAB6fFhboMcwBEN5yvKNmmjuUvlp/46LOtoNWamZmw3R7QkBcbl+A==",
                            PhoneNumber = "+994502330644",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3",
                            TwoFactorEnabled = false,
                            UserName = "Axmed Mustafa"
                        });
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<DateTime?>("FinishWork")
                        .HasColumnType("datetime2")
                        .HasColumnName("FinishWork");

                    b.Property<int>("FixSalary")
                        .HasColumnType("int")
                        .HasColumnName("FixSalary");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FullName");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint")
                        .HasColumnName("Gender");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("PhoneNumber");

                    b.Property<DateTime>("StartWork")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartWork");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.Property<byte>("WorkPosition")
                        .HasColumnType("tinyint")
                        .HasColumnName("WorkPosition");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.EmployeeLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeId");

                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("StoreId");

                    b.ToTable("EmployeeLogs", (string)null);
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Punkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Name");

                    b.Property<string>("Point")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Point");

                    b.HasKey("Id");

                    b.ToTable("Punkts", (string)null);
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdditionalBonus")
                        .HasColumnType("int")
                        .HasColumnName("AdditionalBonus");

                    b.Property<int>("Award")
                        .HasColumnType("int")
                        .HasColumnName("Award");

                    b.Property<int>("Conclusion")
                        .HasColumnType("int")
                        .HasColumnName("Conclusion");

                    b.Property<int>("Countingdown")
                        .HasColumnType("int")
                        .HasColumnName("Countingdown");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeId");

                    b.Property<int>("FixSalary")
                        .HasColumnType("int")
                        .HasColumnName("FixSalary");

                    b.Property<int>("Payment")
                        .HasColumnType("int")
                        .HasColumnName("Payment");

                    b.Property<int>("Penalty")
                        .HasColumnType("int")
                        .HasColumnName("Penalty");

                    b.Property<decimal>("Sales")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Sales");

                    b.Property<decimal>("TotalCheck")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TotalCheck");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Salaries", (string)null);
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Stores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Azadliq"
                        });
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppRoleClaim", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Edentity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUserClaim", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Edentity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUserLogin", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Edentity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUserRole", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Edentity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IydePersonal.Domain.Entities.Edentity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUserToken", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Edentity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Employee", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Edentity.AppUser", "User")
                        .WithMany("Employees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.EmployeeLog", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeLogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IydePersonal.Domain.Entities.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Salary", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Employee", "Employee")
                        .WithMany("Salaries")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Edentity.AppUser", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeLogs");

                    b.Navigation("Salaries");
                });
#pragma warning restore 612, 618
        }
    }
}
