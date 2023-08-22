using Hanssens.Net;
using System.Reflection;
using TheWildNature.MVC.Contracts;
using TheWildNature.MVC.Contracts.Kitchen;
using TheWildNature.MVC.Services;
using TheWildNature.MVC.Services.Base;
using TheWildNature.MVC.Services.Kitchen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IClient, Client>
    (builder.Configuration.GetSection("ApiAddress").Value);

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddSingleton<ILocalStorageService, LocalStorageService>();
builder.Services.AddScoped<IKitchenService, KitchenService>();
// Add services to the container.
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
