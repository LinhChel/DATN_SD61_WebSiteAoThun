using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StyleTee.Data;
using StyleTee.Models;
using StyleTee.Repository;
using StyleTee.Service.IService;
using StyleTee.Service.Service;
using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore; // Add this using directive

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IAllRepositories<>), typeof(AllRepositories<>));
builder.Services.AddScoped<ITaiKhoanService, TaiKhoanService>();
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint(); // This method is available after adding the using directive
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
