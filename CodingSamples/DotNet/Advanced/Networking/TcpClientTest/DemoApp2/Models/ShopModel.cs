namespace DemoApp.Models;

public class ShopModel(string remote)
{
    public async ValueTask<ItemInfo> FetchItemInfoAsync(string name)
    {
        string url = $"http://{remote}/shop/";
        using HttpClient connection = new HttpClient { BaseAddress = new Uri(url) };
        var response = await connection.GetAsync(name);
        if(response.IsSuccessStatusCode)
        {
            string message = await response.Content.ReadAsStringAsync();
            return ItemInfo.Parse(message);
        }
        return default; 
    }
}