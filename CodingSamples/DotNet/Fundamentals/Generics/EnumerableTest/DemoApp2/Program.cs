if(args.Length == 0)
{
    //ICollection<Interval> store = new List<Interval>();
    //ICollection<Interval> store = new HashSet<Interval>();
    ICollection<Interval> store = new SortedSet<Interval>();
    store.Add(new Interval(5, 21));
    store.Add(new Interval(4, 81));
    store.Add(new Interval(6, 12));
    store.Add(new Interval(7, 23));
    store.Add(new Interval(3, 54));
    store.Add(new Interval(2, 35));
    foreach(Interval i in store)
        Console.WriteLine(i);
}
else
{
    //IDictionary<string, Interval> store = new Dictionary<string, Interval>();
    //IDictionary<string, Interval> store = new SortedList<string, Interval>();
    IDictionary<string, Interval> store = new SortedDictionary<string, Interval>();
    store.Add("monday", new Interval(5, 21));
    store.Add("tuesday", new Interval(6, 12));
    store.Add("wednesday", new Interval(7, 23));
    store.Add("thursday", new Interval(3, 54));
    store["friday"] = new Interval(2, 35);
    store["monday"] = new Interval(4, 21);
    string day = args[0].ToLower();
    if(store.TryGetValue(day, out Interval? val))
    {
        Console.WriteLine("Value = {0}", val);
    }
    else
    {
        foreach(var entry in store)
            Console.WriteLine("{0, -12}{1, 9}", entry.Key, entry.Value);
    }
}