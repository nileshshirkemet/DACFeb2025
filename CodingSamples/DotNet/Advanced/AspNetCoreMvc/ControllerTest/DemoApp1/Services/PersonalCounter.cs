namespace DemoApp.Services;

public class PersonalCounter : IVisitCounter
{
    private Dictionary<string, int> store = [];

    public int NextCount(string id)
    {
        lock(store)
        {
            store.TryGetValue(id, out int count);
            store[id] = ++count;
            return count;
        }
    }
}