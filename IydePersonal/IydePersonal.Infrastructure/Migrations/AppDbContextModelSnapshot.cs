﻿// <auto-generated />
using System;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IydePersonal.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("FisrtName")
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
                            ConcurrencyStamp = "83a19c77-00dd-40f5-bcf4-a512132ad5fe",
                            Email = "Prince.1987@mail.ru",
                            EmailConfirmed = false,
                            FisrtName = "Ehmed",
                            LastName = "Mustafa",
                            LockoutEnabled = false,
                            NormalizedEmail = "PRINCE.1987@MAIL.RU",
                            NormalizedUserName = "EHMED MUSTAFA",
                            PasswordHash = "AQAAAAIAAYagAAAAEGSFyQ/WvyJ26SqKoVGlIynmJdmEyezfGBpJ86wjWDl8ORRxGusJh8k6TauarEVUXw==",
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
                            ConcurrencyStamp = "d825ecd0-3ca6-4cfb-a5b0-d32ae44d1342",
                            Email = "Prince.1987@mail.ru",
                            EmailConfirmed = false,
                            FisrtName = "Omer",
                            LastName = "Mustafa",
                            LockoutEnabled = false,
                            NormalizedEmail = "PRINCE.1987@MAIL.RU",
                            NormalizedUserName = "OMER MUSTAFA",
                            PasswordHash = "AQAAAAIAAYagAAAAEOP6ukT19zr/nry5vFBWhgJkRGED43R4l5CtirNwn8GTDbAwcdovZh+TfjgXdr2JlQ==",
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
                            ConcurrencyStamp = "9f96a3a1-71d1-4da1-a4fd-bd17bb55b549",
                            Email = "Prince.1987@mail.ru",
                            EmailConfirmed = false,
                            FisrtName = "Axmed",
                            LastName = "Mustafa",
                            LockoutEnabled = false,
                            NormalizedEmail = "PRINCE.1987@MAIL.RU",
                            NormalizedUserName = "AXMED MUSTAFA",
                            PasswordHash = "AQAAAAIAAYagAAAAEKvxMGU1AlnkcAn9Bv3JOx1YvW6uhq9lDdvBIOv/TL+1enYS1KiGQ+PoHW8x0R0SdA==",
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

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<DateTime?>("FinishWork")
                        .HasColumnType("datetime2")
                        .HasColumnName("FinishWork");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Firstname");

                    b.Property<int>("FixSalary")
                        .HasColumnType("int")
                        .HasColumnName("FixSalary");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint")
                        .HasColumnName("Gender");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Lastname");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("PhoneNumber");

                    b.Property<DateTime>("StartWork")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartWork");

                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("StoreId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.Property<byte>("WorkPosition")
                        .HasColumnType("tinyint")
                        .HasColumnName("WorkPosition");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

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

            modelBuilder.Entity("IydePersonal.Domain.Entities.EmployeePunkt", b =>
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

                    b.Property<int>("PunktId")
                        .HasColumnType("int")
                        .HasColumnName("PunktId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PunktId");

                    b.ToTable("EmployeePunkts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 11, 14, 13, 12, 35, 178, DateTimeKind.Local).AddTicks(7719),
                            EmployeeId = 1,
                            PunktId = 1
                        });
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

                    b.Property<int>("Point")
                        .HasColumnType("int")
                        .HasColumnName("Point");

                    b.HasKey("Id");

                    b.ToTable("Punkts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nizami intizam pozmaq",
                            Point = 20
                        });
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

            modelBuilder.Entity("IydePersonal.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Username");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "123456",
                            UserName = "Azadliq"
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
                    b.HasOne("IydePersonal.Domain.Entities.Store", "Store")
                        .WithMany("Employees")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IydePersonal.Domain.Entities.User", "User")
                        .WithMany("Employees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");

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

            modelBuilder.Entity("IydePersonal.Domain.Entities.EmployeePunkt", b =>
                {
                    b.HasOne("IydePersonal.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeePunkts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IydePersonal.Domain.Entities.Punkt", "Punkt")
                        .WithMany("EmployeePunkts")
                        .HasForeignKey("PunktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Punkt");
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

            modelBuilder.Entity("IydePersonal.Domain.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeLogs");

                    b.Navigation("EmployeePunkts");

                    b.Navigation("Salaries");
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Punkt", b =>
                {
                    b.Navigation("EmployeePunkts");
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.Store", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("IydePersonal.Domain.Entities.User", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
