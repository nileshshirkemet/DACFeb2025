namespace Taxation;

public struct Worker(int jobs) : ITaxPayer
{
    //explicit interface implementation - a type can provide
    //private implementation for a method(M) it inherits from
    //an interface(I) by using its interface qualified name(I.M),
    //such a method can only be called on an reference of that
    //interface type
    decimal ITaxPayer.AnnualIncome()
    {
        return 180000 + 500 * jobs;
    }
}