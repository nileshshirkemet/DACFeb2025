//implementation of type declared with partial keyword can be split
//across multiple source files each defining its own set of members
//for that type, it is commonly used to define additional members
//for auto-generated types
using Banking;

partial class Program
{
    //the last array type parameter declared with params keyword
    //can accept elements of this array as separate arguments,
    //such methods are called variadic functions since they
    //can accept multiple number of arguments
    public static void PayInterest(int quarters, params Account[] accounts)
    {
        foreach(Account acc in accounts)
        {
            IProfitable p = acc as IProfitable; //dynamic (side) casting, returns null if casting fails
            p?.AddInterest(3 * quarters); //if(p != null) p.AddInterest(3 * quarters)
        }
    }
}

