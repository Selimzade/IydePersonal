using IydePersonal.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace IydePersonal.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Punkt> Punkts { get; set; }
    }
}
