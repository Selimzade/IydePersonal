using IydePersonal.API.Data.Configurations;
using IydePersonal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Punkt> Punkts { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<EmployeeLog> EmployeeLogs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EmployeePunkt> EmployeePunkts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new PunktConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeePunktConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new SalaryConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeLogConfiguration());
            

            base.OnModelCreating(modelBuilder);
        }
    }

    
}
