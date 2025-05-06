class Investment {

    private double installment;
    private int years;

    public Investment(double amount, int count) {
        installment = amount;
        years = count;
    }

    public double futureValue(InterestRate interest) {
        double i = interest.forPeriod(years) / 100;
        return (installment / i) * (Math.pow(1 + i, years) - 1);
    }
}
