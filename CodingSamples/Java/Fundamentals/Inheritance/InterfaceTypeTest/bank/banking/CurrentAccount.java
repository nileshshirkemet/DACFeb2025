package banking;

//a class defined with final keyword cannot be extended
final class CurrentAccount extends Account {
   
    public void deposit(double amount) {
        if(balance < 0)
            amount -= 500;
        balance += amount;
    }

    public void withdraw(double amount) throws InsufficientFundsException {
        balance -= amount;
    }
}

