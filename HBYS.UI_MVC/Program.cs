using HBYS.BLL.Repositories.BaseRepository;
using HBYS.BLL.Repositories.Concreate;
using HBYS.BLL.Services;
using HBYS.BLL.Services.Contract;
using HBYS.DAL.DataContext;
using HBYS.DAL.Entities.Concreate;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<HBYSDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));

builder.Services.AddTransient<IRepository<Doctor>, BaseRepository<Doctor>>();
builder.Services.AddTransient<IDoctorService, DoctorService>();





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
