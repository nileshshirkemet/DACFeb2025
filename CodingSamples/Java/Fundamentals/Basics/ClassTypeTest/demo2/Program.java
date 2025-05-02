class Program {

    private static void advise(Investment inv) {
        inv.allowRisk(inv.totalPayment() < 500000);
    }

    private static Investment tryPremiumScheme(double amount) {
        if(amount < 100000)
            return null;
        Investment inv = new Investment(amount, 5);
        if(amount >= 200000)
            inv.allowRisk(RiskLevel.LOW);
        else
            inv.allowRisk(RiskLevel.HIGH);
        return inv;
    }

    public static void main(String[] args) {
        double p = Double.parseDouble(args[0]);
        int n = Integer.parseInt(args[1]);
        Investment a = new Investment(p, n);
        System.out.printf("Future value in riskless investment: %.2f%n", a.futureValue());
        a.allowRisk(true);
        System.out.printf("Future value in low-risk investment: %.2f%n", a.futureValue());
        advise(a);
        System.out.printf("Future value in smart investment   : %.2f%n", a.futureValue());
        if(n == 5){
            Investment b = tryPremiumScheme(p);
            if(b != null)
                System.out.printf("Future value in premium investment: %.2f%n", b.futureValue());
        }
    }
}