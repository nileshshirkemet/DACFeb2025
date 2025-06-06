//C# supports top level statements in one source file
//of a project with OutputType as Exe, these statements
//are copied at compile time into the Main method of
//an auto-generated Program class
Console.WriteLine("Welcome User");
Interval a = new Interval(6, 50);
Print("Interval a", a);
Interval b = new Interval(4, 15);
Print("Interval b", b);
Print("Sum", a + b);
Interval c = new Interval(5, 110);
Print("Interval c", c);
Interval d = b;
Print("Interval d", d);
Console.WriteLine("-------------------------------");
Console.WriteLine("a is identical to b: {0}", ReferenceEquals(a, b));
Console.WriteLine("a is identical to c: {0}", ReferenceEquals(a, c));
Console.WriteLine("d is identical to b: {0}", ReferenceEquals(d, b));
Console.WriteLine("-------------------------------");
Console.WriteLine("a is equal to b: {0}", Equals(a, b));
Console.WriteLine("a is equal to c: {0}", Equals(a, c));
Console.WriteLine("d is equal to b: {0}", Equals(d, b));
Console.WriteLine("-------------------------------");
//using instance initializer syntax
Box e = new Box {Length = 12.5f, Breadth = 8.5f, Height = 7.5f };
Print("Box e", e);

//a local function (included withing Main method), such
//functions do not support overloading
void Print(string label, object info)
{
    Console.WriteLine("{0} = {1}", label, info);
}
