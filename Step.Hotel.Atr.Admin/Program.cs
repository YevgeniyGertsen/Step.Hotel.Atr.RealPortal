using Microsoft.EntityFrameworkCore;
using Step.Hotel.Atr.Admin.Data;
using Step.Hotel.Atr.Admin.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string strCon = 
    builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<HotelAtrDbContext>(options =>
options.UseSqlServer(strCon));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
