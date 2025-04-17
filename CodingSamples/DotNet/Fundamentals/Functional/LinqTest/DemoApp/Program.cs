using DemoApp;

if (args[0] == "items")
{
    var selection = Shop.GetItems()
        .Where(i => i.Brand == args[1])
        .Select(i => i.Name.ToUpper());
    foreach(var entry in selection)
        Console.WriteLine(entry);
}
