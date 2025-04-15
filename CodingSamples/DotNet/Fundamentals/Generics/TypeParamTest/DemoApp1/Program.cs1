namespace DemoApp;

class Program
{
    static object Select(int index, object first, object second)
    {
        if((index % 2) == 1)
            return first;
        return second;
    }

    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            int s = int.Parse(args[0]);
            string ss = (string)Select(s, "Tuesday", "Thursday");
            Console.WriteLine($"Selected string = {ss}");
            double sd = (double)Select(s, 23.4, 43.2);
            Console.WriteLine($"Selected double = {sd}");
            //Select(s, "April", 9.7);
        }
    }
}
