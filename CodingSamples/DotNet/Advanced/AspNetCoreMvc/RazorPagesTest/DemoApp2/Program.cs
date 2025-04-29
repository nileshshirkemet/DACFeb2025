using DemoApp.Data.Shopping;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
//enable built-in authentication support this will also
//automatically include middlewares for handling 
//authentication (verifying identity) and authorization 
//(granting permissions)
builder.Services.AddAuthentication()
    .AddCookie(options => options.LoginPath = "/Index");
builder.Services.AddDbContext<ShopDbContext>(options => 
    options.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User ID=dac;Password=Dac@1234;Encrypt=False"));
var app = builder.Build();
app.MapRazorPages();
app.Run();
