namespace Finance;

[AttributeUsage(AttributeTargets.Method)]
public class MaxDurationAttribute(int limit = 5) : Attribute
{
    public int Limit { get; set; } = limit;
}