using System.Text.Json;

namespace DemoApp.Models;

public class ShopModel
{
    private ItemInfo[] items;

    public ShopModel()
    {
        using var input = new FileStream("EviTek.store", FileMode.Open);
        //deserialization is a process of reading objects 
        //from a stream of bytes
        items = JsonSerializer.Deserialize<ItemInfo[]>(input);
    }

    public ItemInfo GetItemInfo(string name)
    {
        return items.FirstOrDefault(i => i.Id == name);
    }

    public void Save()
    {
        using var output = new FileStream("EviTek.store", FileMode.Create);
        //serialization is a process of writing objects 
        //into a stream of bytes
        JsonSerializer.Serialize(output, items);
    }
}