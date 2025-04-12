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

    //extension method - a method of a static class whose first
    //argument is qualified with this keyword, such a method can
    //be called as an instance method of its first argument type
    //by using the namespace of the class in which it is defined
    public static bool Transfer(this Account source, decimal amount, Account target)
    {
        if(ReferenceEquals(source, target))
            return false;
        source.Withdraw(amount);
        target.Deposit(amount);
        return true;
    }
}