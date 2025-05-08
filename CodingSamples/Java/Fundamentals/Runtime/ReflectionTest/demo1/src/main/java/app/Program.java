package app;

import java.lang.reflect.Method;

import finance.Loans;

public class Program {
    
    public static void main(String[] args) throws Throwable {
        double p = Double.parseDouble(args[0]);
        Class<?> c = Class.forName("finance." + args[1]);
        Object policy = c.getConstructor().newInstance();
        Method scheme = c.getMethod(args[2], double.class, int.class);
        int m = 10;
        for(int n = 1; n <= m; ++n){
            //verify first argument (policy) refers to an instance 
            //of declaring class of target method (in scheme), get
            //callable reference to the implementation of target 
            //method and execute this implementation
            double r = (double)scheme.invoke(policy, p, n);
            double emi = Loans.monthlyInstallment(p, n, r);
            System.out.printf("%d\t%.2f%n", n, emi);
        }
    }
}
