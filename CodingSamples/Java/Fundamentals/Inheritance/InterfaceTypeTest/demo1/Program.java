import banking.*; //import all public names from banking package

class Program {

    public static void main(String[] args) {
        Account jill = Banker.openSavingsAccount();
        jill.deposit(5000);
        Account jack = Banker.openCurrentAccount();
        jack.deposit(20000);
        Account john = Banker.openSavingsAccount();
        john.deposit(25000);
        System.out.printf("Jill's Account ID is %d and Balance is %.2f%n", jill.id(), jill.balance());
        System.out.printf("Jack's Account ID is %d and Balance is %.2f%n", jack.id(), jack.balance());
        System.out.printf("John's Account ID is %d and Balance is %.2f%n", john.id(), john.balance());
        System.out.println("-------------------------------------------");
        if(args.length > 0){
            System.out.printf("Jill is paying %s to Jack...%n", args[0]);
            try{
                double payment = Double.parseDouble(args[0]);
                Banker.transfer(jill, payment, jack);
            }catch(InsufficientFundsException e){
                System.out.println("Payment failed due to lack of funds!");
            }catch(Exception e){
                System.out.printf("Error: %s%n", e.getMessage());
            }
        }
        System.out.printf("Jill's New Balance: %.2f%n", jill.balance());
        System.out.printf("Jack's New Balance: %.2f%n", jack.balance());
        System.out.printf("John's New Balance: %.2f%n", john.balance());
    }
}