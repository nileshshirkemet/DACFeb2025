using DemoApp.Shopping.Data;
using Microsoft.EntityFrameworkCore;

using var shop = new ShopDbContext();
if(args.Length == 0)
{
    foreach(var customer in shop.Customers)
        Console.WriteLine("{0}\t{1:0.00}", customer.Id, customer.Credit);
}
else
{
    var customer = shop.Customers
        .Where(c => c.Id == args[0])
        .Include(c => c.Orders) //eager loading of child entities
        .FirstOrDefault();
    if(customer != null)
    {
        foreach(var order in customer.Orders)
            Console.WriteLine("{0}\t{1}\t{2:yyyy-MM-dd}", order.ProductId, order.Quantity, order.OrderDate);
    }
    else
        Console.WriteLine("No such customer!");
}