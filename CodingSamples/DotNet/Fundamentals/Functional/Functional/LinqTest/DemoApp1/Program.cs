using DemoApp;

if (args[0] == "items")
{
    var selection = Shop.GetItems()
        .Where(i => i.Brand == args[1])
        .Select(i => i.Name.ToUpper());
    foreach(var entry in selection)
        Console.WriteLine(entry);
}
else if(args[0] == "customers")
{
    decimal min = decimal.Parse(args[1]);
    var customers = Shop.GetCustomers();
    customers.Add(new Customer("Fahad", 32000, 2));
    var selection = from c in customers
        orderby c.Id descending
        where c.Purchase >= min
        select new //constructing a new instance of an anonymous type with specified properties
        {
            Email = c.Id.ToLower() + "@met.edu",
            Stars = new string('*', c.Rating)
        };
    foreach(var entry in selection)
        Console.WriteLine("{0, -20}{1, 8}", entry.Email, entry.Stars);
}