﻿using IydePersonal.API.Data.Configurations;
using IydePersonal.Domain.Entities;
using IydePersonal.Domain.Entities.Edentity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IydePersonal.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,int,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken>
    {
        public AppDbContext()
        {
                
        }
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Punkt> Punkts { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<EmployeeLog> EmployeeLogs { get; set; }
        public DbSet<DeleteDate> deleteDates { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        //  public DbSet<User> Users { get; set; }
        // public DbSet<EmployeePunkt> EmployeePunkts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new PunktConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeePunktConfiguration());
            //modelBuilder.ApplyConfiguration(new StoreConfiguration());
            //modelBuilder.ApplyConfiguration(new SalaryConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeLogConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            

            base.OnModelCreating(modelBuilder);
        }
    }

    
}
