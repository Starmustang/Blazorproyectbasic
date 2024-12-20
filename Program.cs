using Blazorproyect.Data;
using Blazorproyect.DataAccess;
using Business;
using DataAccess.Servicios;
using DataAccess.Servicios.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<InventaryContext>(options =>
       options.UseMySQL(builder.Configuration.GetConnectionString("InventaryDatabase")));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//servicios con interfaz
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IAlmacenService, AlmacenService>();
builder.Services.AddScoped<IBodegaService, BodegaService>();
builder.Services.AddScoped<IIngresosySalidas, IngresosySalidas>();

//servicios de negocio
builder.Services.AddScoped<B_Product>();
builder.Services.AddScoped<B_Category>();
builder.Services.AddScoped<B_Almacen>();
builder.Services.AddScoped<B_Bodega>();
builder.Services.AddScoped<B_IngresosySalidas>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
