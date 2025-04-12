namespace Banking;

//a class defined with static keyword only contains static members,
//such a class does not support any constructor and as therefore
//cannot be activated
public static class Banker
{
    private static long seed = DateTime.Now.Ticks % 10000000;

    public static Account OpenCurrentAccount()
    {
        //local type var is inferred from the type of its initializer
        var acc = new CurrentAccount();
        acc.Id = ++seed + 100000000;
        return acc;
    }

    public static Account OpenSavingsAccount()
    {
        var acc = new SavingsAccount();
        acc.Id = ++seed + 200000000;
        return acc;
    }

    public static bool Transfer(Account source, Account target, decimal amount)
    {
        if(ReferenceEquals(source, target))
            return false;
        source.Withdraw(amount);
        target.Deposit(amount);
        return true;
    }
}