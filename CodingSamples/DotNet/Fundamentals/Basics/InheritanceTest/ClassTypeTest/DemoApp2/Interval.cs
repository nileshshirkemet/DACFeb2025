//primary constructor
class Interval(int min, int sec)
{
    //read-only properties
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
}