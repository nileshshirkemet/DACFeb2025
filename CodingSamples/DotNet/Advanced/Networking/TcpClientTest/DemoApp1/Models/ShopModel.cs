using System.Net.Sockets;

namespace DemoApp.Models;

public class ShopModel(string remote)
{
    public async ValueTask<ItemInfo> FetchItemInfoAsync(string name)
    {
        //Step 1
        var connection = new TcpClient(remote, 4000);
        //Step 2
        var channel = connection.GetStream();
        using var reader = new StreamReader(channel);
        using var writer = new StreamWriter(channel) { AutoFlush = true };
        await reader.ReadLineAsync(); //receive greeting message
        await writer.WriteLineAsync(name); //send item name
        string message = await reader.ReadLineAsync(); //receive item info
        //Step 3
        connection.Close();
        if(message != null)
            return ItemInfo.Parse(message);
        return default; //new ItemInfo()
    }
}