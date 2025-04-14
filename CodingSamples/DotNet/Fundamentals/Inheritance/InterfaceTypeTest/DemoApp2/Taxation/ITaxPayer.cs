namespace Taxation;

public interface ITaxPayer
{
    decimal AnnualIncome();

    //default interface method - an implicitly virtual method defined
    //in interface with its default implementation, such a method can
    //only be called on interface type reference unless it is overridden
    //by the type inheriting from this interface
    decimal IncomeTax()
    {
        decimal i = AnnualIncome();
        return i > 200000 ? 0.15M * (i - 200000) : 0;
    }
}