namespace DemoApp;

record Item(string Name, string Brand);

//a value type record must be made immutable by
//declaring it with readonly keyword
readonly record struct Customer(string Id, decimal Purchase, int Rating);

class Shop
{
    public static Item[] GetItems()
    {
        return new Item[] 
        {
            new Item("cpu", "intel"),
            new Item("mouse", "logitek"),
            new Item("ddr", "samsung"),
            new Item("cpu", "amd"),
            new Item("motherboard", "intel"),
            new Item("keyboard", "logitek"),
            new Item("ssd", "samsung"),
            new Item("mouse", "microsoft"),
            new Item("monitor", "samsung")
        };
    }

    public ICollection<Customer> GetCustomers()
    {
        return new List<Customer>
        {
            new Customer("Raj", 43000, 3),
            new Customer("Tejas", 24000, 2),
            new Customer("Pranjal", 56000, 4),
            new Customer("Vinita", 19000, 1),
            new Customer("Komal", 72000, 5),
            new Customer("Shubham", 98000, 4),
            new Customer("Manali", 45000, 3),
            new Customer("Ankita", 66000, 2),
            new Customer("Devendra", 120000, 5)
        };
    }
}