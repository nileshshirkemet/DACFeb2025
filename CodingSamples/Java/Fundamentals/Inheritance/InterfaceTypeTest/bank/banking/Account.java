package banking;

//a class defined with abstract keyword cannot be instantiated
public abstract class Account {
    
    long id;
    protected double balance;

    public long id() {
        return id;
    }

    public double balance() {
        return balance;
    }

    //a method declared with abstract keyword
    //must be overridden in the subclass
    public abstract void deposit(double amount);

    public abstract void withdraw(double amount) throws InsufficientFundsException;

    //a method declared with final keyword cannot be overridden
    public final void freeze() {
        id = -id;
    }
}

