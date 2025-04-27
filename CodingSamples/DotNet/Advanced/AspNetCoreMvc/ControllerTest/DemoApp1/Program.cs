using DemoApp.Services;
using DemoApp.Tourism.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //enable MVC
builder.Services.AddSingleton<IVisitCounter, PersonalCounter>();
builder.Services.AddTransient<SiteModel>();
var app = builder.Build();
//map an action method with name Y exposed by Controller derived class
//with name XContoller as a handler for path /X/Y with X=Home and Y=Index
//by default
app.MapDefaultControllerRoute();
app.Run();
