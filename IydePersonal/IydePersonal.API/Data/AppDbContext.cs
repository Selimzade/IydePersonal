using IydePersonal.API.Entities;
using IydePersonal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IydePersonal.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Punkt> Punkts { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<EmployeeLog> employeeLogs { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Salary>().ToTable(nameof(Salary));
            modelBuilder.Entity<Employee>().ToTable(nameof(Employee));
            modelBuilder.Entity<Punkt>().ToTable(nameof(Punkt));
            modelBuilder.Entity<Store>().ToTable(nameof(Store));
            modelBuilder.Entity<EmployeeLog>().ToTable(nameof(EmployeeLog));

        }
    }

    
}
