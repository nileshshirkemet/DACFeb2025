#nullable disable

class Interval(int min, int sec) : IComparable<Interval>
{
    public int Minutes { get; } = min + sec / 60;

    public int Seconds { get; } = sec % 60;

    public Interval() : this(0, 0)
    {  
    }

    public int Time()
    {
        return 60 * Minutes + Seconds;
    }

    public static Interval operator+(Interval lhs, Interval rhs)
    {
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }

    public override string ToString()
    {
        if(Seconds >= 10)
            return Minutes + ":" + Seconds;
        return Minutes + ":0" + Seconds;
    }

    public override int GetHashCode()
    {
        return Minutes + Seconds;
    }

    public override bool Equals(object other)
    {
        if(other is Interval)
        {
            Interval that = (Interval)other; 
            return this.Minutes == that.Minutes && this.Seconds == that.Seconds;
        }
        return false;
    }

    public int CompareTo(Interval that)
    {
        return this.Time() - that.Time();
    }
}