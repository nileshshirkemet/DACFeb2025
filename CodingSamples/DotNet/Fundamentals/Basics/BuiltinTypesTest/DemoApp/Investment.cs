class Investment
{
    //a member declared with 'public' keyword is visible outside its class
    //a method declared with 'static' keyword must be called on the class
    //using . operatoor
    public static double FutureValue(double installment, int years, bool risk)
    {
        double i = risk ? 0.08 : 0.06;
        return (installment / i) * (System.Math.Pow(1 + i, years) - 1);
    }
}
