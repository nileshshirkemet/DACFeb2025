﻿using Taxation;

namespace DemoApp;

class Program
{
    //nested class can only refer to non-static members of outer class
    class Auditor : IDisposable
    {
        public Auditor()
        {
            Console.WriteLine("Auditor - acquiring required resources...");
        }

        public void Audit(string id, ITaxPayer payer)
        {
            Console.WriteLine($"Auditing {id}....");
            if(id.Length < 4)
                throw new ArgumentException("Invalid ID");
            decimal payment = payer.IncomeTax() + 150;
            Console.WriteLine($"Tax Payment: {payment:0.00}");
        }

        public void Dispose()
        {
            Console.WriteLine("Auditor - releasing acquired resources...");
        }
    }

    static void DoAuditing(string name, int count)
    {
        //Dispose() method is automatically called on a local variable
        //of IDisposable type declared within scope of using statement
        //at the end of this scope
        using(var a = new Auditor())
        {
            if(count > 10)
                a.Audit(name, new Worker(count));
            else
                a.Audit(name, new Supervisor(count));
        }
    }

    static void Main(string[] args)
    {
        try
        {
            string m = args[0].ToUpper();
            int n = int.Parse(args[1]);
            DoAuditing(m, n);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
