class Investment {
    
    //a method declared with public keyword is visible outside of its class,
    //a method declared with static keyword can be called on the class itself
    public static double futureValue(double installment, int years, boolean risk) {
        double i = risk ? 0.08 : 0.06;
        return (installment / i) * (Math.pow(1 + i, years) - 1);
    }
}
