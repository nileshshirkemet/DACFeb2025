delegate double InterestRate(int period);

class Investment(double installment, int years)
{
    public double FutureValue(InterestRate scheme)
    {
        double i = scheme.Invoke(years) / 100;
        return (installment / i) * (Math.Pow(1 + i, years) - 1);
    }
}