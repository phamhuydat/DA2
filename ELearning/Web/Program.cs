using Web.WebConfig;
using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();


builder.Services.AddApplicationServices(builder.Configuration, builder.Environment);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error/500");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Điều hướng khi gặp lỗi
app.UseStatusCodePagesWithReExecute("/error/{0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(static endpoints =>
{
    // Định tuyến cho client login
    endpoints.MapControllerRoute(
        name: "clientLogin",
        pattern: "login",  // Không cần dấu `/` ở đầu
        defaults: new
        {
            controller = "Account",
            action = "Login"
        });

    // Định tuyến cho admin login
    _ = endpoints.MapAreaControllerRoute(
        areaName: "Admin",
        name: "adminLogin",
        pattern: "admin/login",  // Sử dụng đường dẫn khác cho admin
        defaults: new
        {
            controller = "Account",
            action = "Login",
            area = "Admin"
        });

    // Đường dẫn cho trang lỗi
    endpoints.MapControllerRoute(
        name: "error",
        pattern: "error/{statusCode}",
        defaults: new
        {
            controller = "Home",
            action = "Error"
        });

    endpoints.MapAreaControllerRoute(
      areaName: "Admin",
      name: "Admin",
      pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

    // Định tuyến cho các trang ngoài area (Client)
    endpoints.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    // Định tuyến khu vực Admin



});


app.Run();
