
using System.Net;
using System.Net.Sockets;
using DemoApp.Models;

namespace DemoApp;

//worker service
public class ShopServer(IConfiguration config, ILogger<ShopServer> logger, ShopModel model) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        int port = config.GetValue<int>("Listener:Port", 4002);
        logger.LogInformation("Starting shop server on TCP port {p}", port);
        var listener = new TcpListener(IPAddress.Any, port);
        listener.Start();
        while(!stoppingToken.IsCancellationRequested)
        {
            var client = await listener.AcceptTcpClientAsync();
            CommunicateWith(client);
        }
    }

    private async void CommunicateWith(TcpClient connection)
    {
        try
        {
            var channel = connection.GetStream();
            using var reader = new StreamReader(channel);
            using var writer = new StreamWriter(channel) { AutoFlush = true };
            await writer.WriteLineAsync("Welcome to EviTek computers.");
            string name = await reader.ReadLineAsync();
            ItemInfo info = model.GetItemInfo(name);
            if(info is not null)
                await writer.WriteLineAsync($"cost={info.Cost}&stock={info.Stock}");
        }
        catch(Exception ex)
        {
            logger.LogError(ex, "Communication failure");
        }
        connection.Close();
    }

}
