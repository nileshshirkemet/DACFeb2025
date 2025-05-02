class Program {

    private static void advise(Investment inv) {
        inv.allowRisk(inv.totalPayment() < 500000);
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
    }
}