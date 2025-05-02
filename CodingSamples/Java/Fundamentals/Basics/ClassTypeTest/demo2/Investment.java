class Investment {

    private double installment;
    private int years;
    private RiskLevel risk;

    public Investment(double amount, int count)
    {
        installment = amount;
        years = count;
        risk = RiskLevel.NONE;
    }

    public void allowRisk(boolean yes) {
        risk = yes ? RiskLevel.LOW : RiskLevel.NONE;
    }

    //method overloading - defining a methid with 
    //the same name as another method in the class 
    //but with different list of parameter types
    public void allowRisk(RiskLevel level) {
        risk = level;
    }

    public double totalPayment() {
        return installment * years;
    }

    public double futureValue() {
        double i;
        switch(risk){
            case LOW:
                i = 0.08;
                break;
            case HIGH:
                i = 0.12;
                break;
            default:
                i = 0.06;
        }
        return (installment / i) * (Math.pow(1 + i, years) - 1);
    }
}
