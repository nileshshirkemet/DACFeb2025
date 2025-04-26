using DemoApp.Endpoints;
using DemoApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(); //enable sessions
var app = builder.Build();
app.UseSession();
app.UseStaticFiles();
app.UseMiddleware<Pausing>();
app.MapGet("/Home", Greeting.Welcome);
app.MapPost("/Login", Greeting.Hello);
app.Run();
