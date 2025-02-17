using IydePersonal.Application;
using IydePersonal.Application.FluentValidations;
using IydePersonal.Domain.Entities.Edentity;
using IydePersonal.Infrastructure;
using IydePersonal.Infrastructure.Data;
using IydePersonal.WEB;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddInfrastructure(config);
builder.Services.AddApplication();
builder.Services.AddSession();


// Add services to the container.
builder.Services.AddControllersWithViews().
    AddNToastNotifyToastr(new ToastrOptions()
    {
        PositionClass = ToastPositions.BottomRight,
        TimeOut = 3000
    }
    )
    .AddRazorRuntimeCompilation();

builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequiredLength = 0;
})
    .AddRoleManager<RoleManager<AppRole>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

//builder.Services.AddIdentity<AppUser, IdentityRole>()
//    .AddEntityFrameworkStores<AppDbContext>()
//    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(opt => opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 .");

builder.Services.AddSingleton<IUserValidator<AppUser>, CustomUserValidator>();

builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = new PathString("/Admin/Auth/Login");
    config.LogoutPath = new PathString("/Admin/Auth/Logout");
    config.Cookie = new CookieBuilder
    {
        Name = "IydeInfo",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest
    };
    config.SlidingExpiration=true;
    config.ExpireTimeSpan=TimeSpan.FromDays(1);
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");

});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseNToastNotify();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

using var scope = app.Services.CreateScope();

var dbCpntext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

dbCpntext.Database.Migrate();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
         pattern: "Admin/{controller=Auth}/{action=Login}/{id?}"
        );
    endpoints.MapDefaultControllerRoute();
});
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapAreaControllerRoute(
//        name: "admin",
//        areaName: "Admin",
//        pattern: "Admin/{controller=Auth}/{action=Login}/{id?}"
//    );

//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//});

app.Run();
