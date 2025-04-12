namespace Banking;

//a class declared with sealed keyword cannot be used
//as a base class for other class
sealed class CurrentAccount : Account
{
    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if(Id < 0)
            throw new NotSupportedException("Account is locked.");
        Balance -= amount;
    }
}