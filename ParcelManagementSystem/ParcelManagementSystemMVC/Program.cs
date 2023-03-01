using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ParcelManagementSystemMVC.DBCOnnect;
using ParcelManagementSystemMVC.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//ServiceProvider provider = builder.Services.BuildServiceProvider();
//var _ = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<EmplDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));


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