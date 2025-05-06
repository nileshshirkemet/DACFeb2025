class Program {

    private static double safeScheme(int years) {
        return years < 3 ? 5.5 : 6;
    }

    public static void main(String[] args) {
        double p = Double.parseDouble(args[0]);
        int n = Integer.parseInt(args[1]);
        var inv = new Investment(p, n);
        //passing a method reference for a functional interface,
        //the runtime will generate implementation for this 
        //interface to invoke the referenced method
        System.out.printf("Future value in riskless investment: %.2f%n", inv.futureValue(Program::safeScheme));
        //passing lambda-expression(an anonymous method reference)
        System.out.printf("Future value in riskful investment : %.2f%n", inv.futureValue(y -> 8 + 0.25 * y));
    }
}