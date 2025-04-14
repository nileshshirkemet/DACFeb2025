namespace Banking;

//a class defined with public keyword is visible
//to other referencing assemblies/projects
//a class defined with abstract keyword does not
//support activation, it can only be used as a 
//base class for other classes
public abstract class Account
{
    public long Id { get; internal set; }

    public decimal Balance { get; protected set; }

    //a method declared with abstract keyword is a pure virtual
    //instance method, it can only appear in an abstract class and
    //it must be overridden by a non-abstract derived class 
    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);

    public void Freeze()
    {
        Id = -Id;
    }
}