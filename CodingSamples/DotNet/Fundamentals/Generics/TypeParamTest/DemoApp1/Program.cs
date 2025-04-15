namespace DemoApp;

class Program
{
    static T Select<T>(int index, T first, T second) 
    {
        if((index % 2) == 1)
            return first;
        return second;
    }

    static T Select<T>(T first, T second) where T: IComparable<T>
    {
        if(first.CompareTo(second) > 0)
            return first;
        return second;
    }

    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            int s = int.Parse(args[0]);
            string ss = Select(s, "Tuesday", "Thursday");
            Console.WriteLine($"Selected string = {ss}");
            double sd = Select(s, 23.4, 43.2);
            Console.WriteLine($"Selected double = {sd}");
            //Select(s, "April", 9.7);
        }
        else
        {
            string ss = Select("Tuesday", "Thursday");
            Console.WriteLine($"Selected string = {ss}");
            double sd = Select(23.4, 43.2);
            Console.WriteLine($"Selected double = {sd}");            
            Interval si = Select(new Interval(4, 30), new Interval(3, 20));
            Console.WriteLine($"Selected Interval = {si}");
        }
    }
}
