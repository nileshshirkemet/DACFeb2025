using DemoApp.Shopping.Data;
using Microsoft.EntityFrameworkCore;
using Sales;

var db = new DbContextOptionsBuilder<ShopDbContext>();
if(args[0] == "local")
    db.UseSqlite("Data Source=shop.db");
else
    db.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False");
using var shop = new ShopDbContext(db.Options);
if(args.Length < 2)
{
    foreach(var entry in shop.Products)
        Console.WriteLine("{0}\t{1:0.00}", entry.Id, entry.Price);
}
else
{
    int pno = int.Parse(args[1]);
    var product = shop.Products.Find(pno);
    if(product != null)
    {
        shop.Entry(product).Collection(p => p.Orders).Load(); //explicit loading of child entities
        Console.WriteLine("Total Sales: {0:0.00}", product.GetTotalSales());
    }
    else
        Console.WriteLine("No such product!");
}