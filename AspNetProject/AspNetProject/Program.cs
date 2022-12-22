using Core.Entities;
using DataAcces.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Service
builder.Services.AddControllersWithViews();
var constr = builder.Configuration["ConnectionString:Default"];
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(constr);
});
var app = builder.Build();

//Handle Http request
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}"
    );
app.Run();

