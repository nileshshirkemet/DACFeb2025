using DemoApp.Models;

string item = args[0].ToLower();
int quantity = int.Parse(args[1]);
var shop = new ShopModel(args[2]);
ItemInfo info = await shop.FetchItemInfoAsync(item);
if(quantity <= info.Stock)
    Console.WriteLine("Total Payment: {0:00}", 1.18 * quantity * info.Cost);
else
    Console.WriteLine("Not in stock!");
