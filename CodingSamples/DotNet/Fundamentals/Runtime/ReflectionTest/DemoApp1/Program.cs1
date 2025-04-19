using Finance;

decimal p = decimal.Parse(args[0]);
Type t = Type.GetType($"Finance.{args[1]},BankFinLib", true);
//strict type checking is disabled for dynamic type variable
dynamic policy = Activator.CreateInstance(t); //dynamic activation
int m = 10;
for(int n = 1; n <= m; ++n)
{
    float r = policy.Common(p, n); //generate runtime-binder based call (duck typing)
    decimal e = Loans.GetMonthlyInstallment(p, n, r);
    Console.WriteLine("{0, -6}{1, 12:0.00}", n, e);
}
