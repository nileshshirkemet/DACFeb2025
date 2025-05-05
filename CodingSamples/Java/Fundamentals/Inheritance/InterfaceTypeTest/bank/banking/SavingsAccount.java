package banking;

final class SavingsAccount extends Account implements Profitable{
    
    //a field defined with final keyword cannot be reassigned
    static final double MIN_BAL = 5000;

    SavingsAccount() {
        balance = MIN_BAL;
    }

    public void deposit(double amount) {
        balance += amount;
    }

    public void withdraw(double amount) throws InsufficientFundsException {
        if(balance - amount < MIN_BAL)
            throw new InsufficientFundsException();
        balance -= amount;
    }

    public double interest(int months) {
        double rate = balance < 5 * MIN_BAL ? MIN_RATE : MIN_RATE + 0.5;
        return balance * rate * months / 1200;
    }
}
