using System.Reflection;
using Finance;
using RateFunc = System.Func<decimal, int, float>;

decimal p = decimal.Parse(args[0]);
Type t = Type.GetType($"Finance.{args[1]},BankFinLib", true);
object policy = Activator.CreateInstance(t); 
MethodInfo scheme = t.GetMethod(args[2]);
//verify the target method in scheme is supported by 
//the type of instance refered by policy if so obtain
//the reference to the implementation of this method
//for that instance and initialize the delegate
RateFunc rf = scheme.CreateDelegate<RateFunc>(policy);
MaxDurationAttribute md = scheme.GetCustomAttribute<MaxDurationAttribute>();
int m = md?.Limit ?? 10; //md != null ? md.Limit : 10;
for(int n = 1; n <= m; ++n)
{
    float r = rf(p, n); //execute the implementation
    decimal e = Loans.GetMonthlyInstallment(p, n, r);
    Console.WriteLine("{0, -6}{1, 12:0.00}", n, e);
}

//delegate float RateFunc(decimal amount, int period);