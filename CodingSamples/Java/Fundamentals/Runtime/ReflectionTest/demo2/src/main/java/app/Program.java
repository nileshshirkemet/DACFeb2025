package app;

import java.lang.invoke.MethodHandle;
import java.lang.invoke.MethodHandles;
import java.lang.reflect.Method;

import finance.Loans;
import finance.MaxDuration;

public class Program {
    
    public static void main(String[] args) throws Throwable {
        double p = Double.parseDouble(args[0]);
        Class<?> c = Class.forName("finance." + args[1]);
        Object policy = c.getConstructor().newInstance();
        Method scheme = c.getMethod(args[2], double.class, int.class);
        MaxDuration md = scheme.getAnnotation(MaxDuration.class);
        int m = md != null ? md.value() : 10;
        //a MethodHandle represents a direct typed reference
        //to a method and refers to the implementation of
        //this method for the object it is bound to
        MethodHandle schemeHandle = MethodHandles.lookup()
            .unreflect(scheme)
            .bindTo(policy);
        for(int n = 1; n <= m; ++n){
            double r = (double)schemeHandle.invoke(p, n);
            double emi = Loans.monthlyInstallment(p, n, r);
            System.out.printf("%d\t%.2f%n", n, emi);
        }
    }
}
