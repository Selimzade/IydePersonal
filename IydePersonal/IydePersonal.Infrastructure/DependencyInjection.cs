using IydePersonal.Application.Repositories;
using IydePersonal.Infrastructure.Data;
using IydePersonal.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IydePersonal.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IPunktRepository, PunktRepository>();
            services.AddScoped<IStoreRepostory, StoreRepostory>();
            services.AddScoped<IUserRepository, UserRepostory>();
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
