using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Shopping;
using ServerApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc(); //enable GRPC
builder.Services.AddDbContext<ShopDbContext>(options => options
    .UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False")    
);
var app = builder.Build();
//Kestrel must be configured (see appsettings.json) 
//to support HTTP/2 endpoint as it is required by gRPC
app.MapGrpcService<OrderManagerService>();
app.Run();
