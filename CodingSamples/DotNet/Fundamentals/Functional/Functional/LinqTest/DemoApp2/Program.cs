using System.Xml.Linq;

var doc = XElement.Load("suppliers.xml");
var selection = from x in doc.Elements("Supplier")
    select new 
    {
        Name = x.Attribute("Id").Value,
        Item = x.Element("Component").Value,
        Quantity = (int)x.Element("Stock")
    };
foreach(var entry in selection.OrderBy(e => e.Name))
    Console.WriteLine("{0, -12}{1, -12}{2, 8}", entry.Name, entry.Item, entry.Quantity);
Console.WriteLine("----------------------------");
if(args.Length > 0)
{
    int total = selection.Where(e => e.Item == args[0]).Sum(e => e.Quantity);
    Console.WriteLine("Total supply for {0}: {1}", args[0], total);
}
