namespace Banking;

class SavingsAccount : Account
{
    //an identifier declared with const keyword is replaced
    //by its initialier value wher eever it appears in code
    const decimal MinBal = 5000;

    internal SavingsAccount()
    {
        Balance = MinBal;
    }

    public override void Deposit(decimal amount)
    {
        if(Balance >= 50000)
            amount -= 100;
        Balance += amount;
    }

    //a method declared with sealed keyword cannot be
    //further overridden in the derived class
    public sealed override void Withdraw(decimal amount)
    {
        if(Id < 0)
            throw new NotSupportedException("Account is locked.");
        if(Balance - amount < MinBal)
            throw new InsufficientFundsException();
        Balance -= amount;
    }
}