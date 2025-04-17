namespace DemoApp;

using Common;

class Program
{
    static void PrintFormated(IStackReader<object> stack)
    {
        Console.WriteLine("<items>");
        while(!stack.Empty())
            Console.WriteLine("  <item>{0}</item>", stack.Pop());
        Console.WriteLine("</items>");
    }

    static void Main(string[] args)
    {
        SimpleStack<string> a = new SimpleStack<string>(); //closed generic type
        a.Push("Monday");
        a.Push("Tuesday");
        a.Push("Wednesday");
        a.Push("Thursday");
        a.Push("Friday");
        //a.Push(3.14);
        PrintFormated(a);
        Console.WriteLine("-------------------");
        SimpleStack<Interval> b = new SimpleStack<Interval>();
        b.Push(new Interval(4, 31));
        b.Push(new Interval(3, 42));
        b.Push(new Interval(5, 13));
        b.Push(new Interval(6, 54));
        PrintFormated(b);
    }
}
