using DemoApp.Endpoints;
using DemoApp.Services;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<IVisitCounter, SharedCounter>();
builder.Services.AddSingleton<IVisitCounter, PersonalCounter>();
var app = builder.Build();
app.MapGet("/Home", Greeting.Welcome);
app.MapPost("/Login", Greeting.Hello);
app.Run();
