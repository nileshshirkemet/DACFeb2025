using System.Net;
using System.Net.Sockets;
using DemoApp.Models;

namespace DemoApp;

public class ShopServer
{
    public void Run()
    {
        var shop = new ShopModel();
        Console.WriteLine("Starting shop server on TCP port 4002...");
        //Step 1
        var listener = new TcpListener(IPAddress.Any, 4002);
        listener.Start();
        while(true)
        {
            //Step 2
            var client = listener.AcceptTcpClient();
            //CommunicateWith(client, shop);
            new Thread(() => CommunicateWith(client, shop)).Start();
        }
    }

    private void CommunicateWith(TcpClient connection, ShopModel model)
    {
        try
        {
            //Step 3
            var channel = connection.GetStream();
            using var reader = new StreamReader(channel);
            using var writer = new StreamWriter(channel) { AutoFlush = true };
            writer.WriteLine("Welcome to EviTek computers.");
            string name = reader.ReadLine();
            ItemInfo info = model.GetItemInfo(name);
            if(info is not null)
                writer.WriteLine($"cost={info.Cost}&stock={info.Stock}");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Communication failure: {0}", ex.Message);
        }
        //Step 4
        connection.Close();
    }
}