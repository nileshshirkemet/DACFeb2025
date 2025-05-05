import banking.*; //import all public names from banking package

class Program {

    //final parameter type declared with ... can receive an array or 
    //a sequence of arguments of that type
    private static void payQuarterlyInterest(int count, Account... accounts) {
        for(Account acc : accounts){
            if(acc instanceof Profitable p){
                double amount = p.interest(3 * count);
                acc.deposit(amount);
            }
        }
    }

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
        if(args.length > 0){
            try{
                double payment = Double.parseDouble(args[0]);
                System.out.printf("Jill is paying %.2f to Jack...%n", payment);
                Banker.transfer(jill, payment, jack);
                System.out.println("Payment succeeded.");
            }catch(InsufficientFundsException e){
                System.out.println("Payment failed due to lack of funds!");
                jill.freeze();
            }catch(Exception e){
                System.out.printf("Error: %s%n", e.getMessage());
            }
        }else{
            System.out.println("Paying annual interest...");
            //payQuarterlyInterest(4, new Account[]{jill, jack, john});
            payQuarterlyInterest(4, jill, jack, john);
        }
        System.out.printf("Jill's Final Balance: %.2f%n", jill.balance());
        System.out.printf("Jack's Final Balance: %.2f%n", jack.balance());
        System.out.printf("John's Final Balance: %.2f%n", john.balance());
    }
}