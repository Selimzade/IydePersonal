using FluentValidation;
using IydePersonal.Application.FluentValidations;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Concretes;
using IydePersonal.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace IydePersonal.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IPunktService, PunktService>();
            services.AddScoped<IStoryService, StoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblyContaining<EmployeeValidator>();
            services.AddValidatorsFromAssemblyContaining<UserValidator>();
            return services;
        }
    }

}