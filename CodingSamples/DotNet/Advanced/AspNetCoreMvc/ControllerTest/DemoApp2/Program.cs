using DemoApp.Tourism.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //enable MVC without support for views
builder.Services.AddTransient<SiteModel>();
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapControllers(); //use attribute routing
app.Run();
