using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.AboutServices;
using BabyCare.Web.Services.BannerService;
using BabyCare.Web.Services.GenericService;
using BabyCare.Web.Services.InstructorServices;
using BabyCare.Web.Services.ProductServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();
builder.Services.AddScoped<IAboutService , AboutService>();
builder.Services.AddScoped<IBannerService , BannerService>();



//AutoMapper Konfigürasyon
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//MongoDB Settings konfigure-baðlantý ayarlarý //singleton
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection(nameof(DatabaseSettings)));


////Service Konfigürasyonu.
//builder.Services.AddScoped<IInstructorService , InstructorService>();
//builder.Services.AddScoped<IProductService ,ProductService>();



builder.Services.AddSingleton<IDataBaseSettings>(sp =>

{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});







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

//Area Konfigürasyonu.
app.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
   );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
