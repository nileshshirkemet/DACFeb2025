using System.Diagnostics;

namespace DemoApp;

class Program
{
    class Computation
    {
        private Stopwatch clock = new();

        public long Compute(int start, int count)
        {
            clock.Start();
            return Enumerable.Range(start, count)
                .AsParallel()
                .Select(Activity.Perform)
                .Sum();
        }

        //Task<T> represents a unit of asynchronous execution
        //which returns a result of type T on completion of
        //this execution
        public Task<long> ComputeAsync(int start, int count)
        {
            //the specified operation will be performed by
            //the worker thread (from CLR's thread pool) allowing
            //the calling thread to resume execution and obtain
            //the result of this operation once the worker thread
            //has completed it
            return Task<long>.Run(() => Compute(start, count));
        }

        public double Time()
        {
            clock.Stop();
            return clock.Elapsed.TotalSeconds;
        }
    }

    //a method declared with async keyword yields 
    //a task of its return type using await operator
    static async Task HandleJob(int jobno)
    {
        Console.Write("Computing...");
        var c = new Computation();
        //await operator yields to the caller a task which on completion
        //of the task to which it is applied executes the statements
        //following its usage
        long r = await c.ComputeAsync(1, jobno);
        Console.WriteLine("Done");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds", r, c.Time());
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 5;
        var job = HandleJob(n);
        while(!job.IsCompleted)
        {
            Console.Write(".");
            Thread.Sleep(300); //pause current thread for 300 milliseconds
        }
    }
}
