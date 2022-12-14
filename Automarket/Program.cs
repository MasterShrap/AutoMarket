using Automarket.DAL.Context;
using Automarket.DAL.Interfaces;
using Automarket.DAL.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ApplicationDbContext, ApplicationDbContext>();

builder.Services.AddScoped<CarRepository, CarRepository>();

var connectionStrings = builder.Configuration.GetConnectionString("CarDbConnection");
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionStrings));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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
