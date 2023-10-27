using Microsoft.EntityFrameworkCore;
using SistemaNassau.Data.Context;
using Microsoft.EntityFrameworkCore.Design;
using Template.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BancoDbContext>(options =>
options.UseMySql("server=localhost;userid=admin;password=123456;database=SistemaNassau", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql")));

NativeInjector.RegisterService(builder.Services);
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
