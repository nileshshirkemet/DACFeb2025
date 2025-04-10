using System;

class Program
{
    static void Advise(ref Investment inv)
    {
        inv.AllowRisk(inv.TotalPayment() < 500000);
    }

    //a parameter of a method qualifed with out keyword can accept 
    //an uninitialized argument which this method must initialize
    //before it returns
    static bool TryPremiumScheme(double amount, out Investment inv)
    {
        if(amount < 100000)
        {
            inv = new Investment();
            return false;
        }
        inv = new Investment(amount, 5);
        if(amount >= 200000)
            inv.AllowRisk(RiskLevel.Low);
        else
            inv.AllowRisk(RiskLevel.High);
        return true;
    }

    static void Main(string[] args)
    {
        double p = double.Parse(args[0]);
        int n = int.Parse(args[1]);
        Investment a = new Investment(p, n);
        Console.WriteLine("Future value in riskless investment: {0:0.00}", a.FutureValue());
        a.AllowRisk(true);
        Console.WriteLine("Future value in low-risk investment: {0:0.00}", a.FutureValue());
        Advise(ref a); 
        Console.WriteLine("Future value in smart investment   : {0:0.00}", a.FutureValue());
        a.AllowRisk(RiskLevel.High);
        Console.WriteLine("Future value in high-risk investment: {0:0.00}", a.FutureValue());
        if(n == 5 && TryPremiumScheme(p, out Investment b))
        {
            Console.WriteLine("Future value in premium investment: {0:0.00}", b.FutureValue());
        }
    }
}
