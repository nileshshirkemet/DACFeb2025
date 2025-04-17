namespace DemoApp;

using Common;

class Program
{
    //BCL provides support for standard iteration through
    //IEnumerable<T> interface which defines GetEnumerator()
    //method with IEnumerator<T> as its return type which
    //defines MoveNext() method and Current property
    static IEnumerable<Interval> RandomIntervals(int count)
    {
        for(int i = 0; i < count; ++i)
        {
            int t = Random.Shared.Next(100, 500);
            //the yield return statement allows a method to return
            //a sequence of values through an auto-generated
            //implementation of interface specified in its return type
            yield return new Interval(0, t);
        }
    }

    static void Main(string[] args)
    {
        SimpleStack<string> a = new SimpleStack<string>(); //closed generic type
        a.Push("Monday");
        a.Push("Tuesday");
        a.Push("Wednesday");
        a.Push("Thursday");
        a.Push("Friday");
        for(var i = a.GetEnumerator(); i.MoveNext();)
            Console.WriteLine(i.Current);
        Console.WriteLine("-----------------");    
        a[2] = "Holiday"; //using indexer
        while(!a.Empty())
            Console.WriteLine(a.Pop());
        Console.WriteLine("-----------------");  
        SimpleStack<double> b = new SimpleStack<double>();
        b.Push(34.21);  
        b.Push(58.62);
        b.Push(75.13);
        b.Push(27.54);
        foreach(double d in b)
            Console.WriteLine(d);
        Console.WriteLine("-----------------"); 
        foreach(Interval v in RandomIntervals(3))
            Console.WriteLine(v); 
    }
}
