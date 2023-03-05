using hdungx99.Movies.MVC.Builder;
using hdungx99.Movies.MVC.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServiceRegister();

var app = builder.Build();

app.AddBuilder(app.Environment.IsDevelopment());

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
