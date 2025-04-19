using System.Reflection;
using Finance;

decimal p = decimal.Parse(args[0]);
Type t = Type.GetType($"Finance.{args[1]},BankFinLib", true);
object policy = Activator.CreateInstance(t); //dynamic activation
MethodInfo scheme = t.GetMethod(args[2]);
int m = 10;
for(int n = 1; n <= m; ++n)
{
    //verify the target method is supported by the type of instance
    //referred by first argument, if so obtain the reference to
    //the implementation of target method for this instance and 
    //execute this implementation by passing it specified arguments
    float r = (float)scheme.Invoke(policy, [p, n]); //late binding
    decimal e = Loans.GetMonthlyInstallment(p, n, r);
    Console.WriteLine("{0, -6}{1, 12:0.00}", n, e);
}
