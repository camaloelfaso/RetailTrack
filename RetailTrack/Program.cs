﻿using Microsoft.EntityFrameworkCore;
using RetailTrack.Data; 
using RetailTrack.Services;

var builder = WebApplication.CreateBuilder(args);

// Configura el DbContext con MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
    .EnableSensitiveDataLogging()
    .LogTo(Console.WriteLine, LogLevel.Information)
    );

// Otros servicios
builder.Services.AddScoped<ProductService>(); 
builder.Services.AddScoped<MovementService>();
builder.Services.AddScoped<DesignService>();
builder.Services.AddScoped<MaterialTypeService>();
builder.Services.AddScoped<MaterialService>();

builder.Services.AddControllersWithViews();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

var app = builder.Build();

// Middleware para registrar todas las solicitudes en consola
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
});

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
