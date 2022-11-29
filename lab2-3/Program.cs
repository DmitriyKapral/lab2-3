using Microsoft.EntityFrameworkCore;
using lab2_3.DAL;

var builder = WebApplication.CreateBuilder(args);


//string connection = builder.Configuration.GetConnectionString("DefaultConnection");


//builder.Services.AddDbContext<ShopContext>(options => options.UseNpgsql(connection));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
