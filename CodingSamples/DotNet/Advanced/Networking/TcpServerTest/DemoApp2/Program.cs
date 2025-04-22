using DemoApp;
using DemoApp.Models;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<ShopServer>();
builder.Services.AddSingleton<ShopModel>();
var app = builder.Build();
app.Run();
