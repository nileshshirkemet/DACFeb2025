package banking;

public class Banker {
    
    private static long nid = System.currentTimeMillis() % 1000000;

    public static Account openCurrentAccount() {
        //automatic type inference for a local variable 
        //from its initializer
        var acc = new CurrentAccount();
        acc.id = ++nid + 100000000;
        return acc;
    }

    public static Account openSavingsAccount() {
        var acc = new SavingsAccount();
        acc.id = ++nid + 200000000;
        return acc;
    }

    public static void transfer(Account source, double amount, Account target) throws InsufficientFundsException {
        if(source == target)
            throw new IllegalTransferException();
        source.withdraw(amount);
        target.deposit(amount);
    }

    //a class with all static members does not require instances
    private Banker() {}
}
