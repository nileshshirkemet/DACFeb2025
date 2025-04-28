using DemoApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();//enable razor pages
builder.Services.AddSingleton<IVisitCounter, PersonalCounter>();
var app = builder.Build();
//map handler for rendering ~/Pages/X.cshtml that begins with @page 
//directive to the path specified in this directive but if path is 
//not specified then map it to /X and use X=Index as default
app.MapRazorPages();
app.Run();
