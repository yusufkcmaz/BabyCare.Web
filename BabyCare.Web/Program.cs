using BabyCare.Web.DataAccess.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//AutoMapper Konfigürasyon
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//MongoDB Settings konfigure-baðlantý ayarlarý
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
//singleton
builder.Services.AddSingleton<IDataBaseSettings>(sp =>

{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});



//singleton



builder.Services.AddControllersWithViews();

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
