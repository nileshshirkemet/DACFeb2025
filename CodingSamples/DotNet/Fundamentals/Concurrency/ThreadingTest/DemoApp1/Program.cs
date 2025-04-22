namespace DemoApp;

class Program
{
    //each thread receives a separate value for this non-local variable,
    //because the value will be placed in thread-local storage (TLS)
    [ThreadStatic] 
    static string manager;

    static void HandleJob(int jobno)
    {
        Console.WriteLine("Thread<{0}> accepted job<{1}> for {2}", Environment.CurrentManagedThreadId, jobno, manager);
        Activity.Perform(jobno);
        Console.WriteLine("Thread<{0}> finished job<{1}> for {2}", Environment.CurrentManagedThreadId, jobno, manager);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 1;
        Thread child = new Thread(() => 
        {
            manager = "Jack";
            HandleJob(n);
        });
        child.IsBackground = n > 9;
        child.Start();
        manager = "Jill";
        HandleJob(2);
    }
}
