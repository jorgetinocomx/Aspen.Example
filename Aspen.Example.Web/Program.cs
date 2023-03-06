using Aspen.Example.DataAccess;
using Aspen.Example.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppDb");

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add db services to SQL server
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// Inject (create the instances) for the business and the data access layer.
builder.Services.AddScoped<IUserData, UserData>();

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
