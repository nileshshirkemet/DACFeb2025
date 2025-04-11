//primary constructor
class Interval(int min, int sec)
{
    //read-only properties (no set block)
    public int Minutes { get; } = min + sec / 60;

    public int Seconds { get; } = sec % 60;

    public int Time()
    {
        return 60 * Minutes + Seconds;
    }

    //overloading addition(+) operator
    public static Interval operator+(Interval lhs, Interval rhs)
    {
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }

    //overriding corresponding method of System.Object to return
    //a string containing values of fields in this instance
    public override string ToString()
    {
        if(Seconds >= 10)
            return Minutes + ":" + Seconds;
        return Minutes + ":0" + Seconds;
    }

    //overriding corresponding method of System object to return
    //an integer obtained by combining values of fields in this
    //instance such that the same integer is returned for two
    //instances with matching field values
    public override int GetHashCode()
    {
        return Minutes + Seconds;
    }

    //overriding corresponding method of System object to return
    //true or false depending on whether or not the values of fields
    //in this instance match with those in instance referred by 
    //the argument passed 
    public override bool Equals(object other)
    {
        if(other is Interval)
        {
            Interval that = (Interval)other; //explicit down-casting
            return this.Minutes == that.Minutes && this.Seconds == that.Seconds;
        }
        return false;
    }
}