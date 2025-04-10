using System;

class Program
{
    //for a parameter declared with ref keyword, the method
    //expects the location of the argument instead of a copy
    //of its value
    static void Advise(ref Investment inv)
    {
        inv.AllowRisk(inv.TotalPayment() < 500000);
    }

    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        int n = int.Parse(args[1]);
        Investment a = new Investment(p, n);
        Console.WriteLine("Future value in riskless investment: {0:0.00}", a.FutureValue());
        a.AllowRisk(true);
        Console.WriteLine("Future value in low-risk investment: {0:0.00}", a.FutureValue());
        Advise(ref a); //passing location of a 
        Console.WriteLine("Future value in smart investment   : {0:0.00}", a.FutureValue());
    }
}