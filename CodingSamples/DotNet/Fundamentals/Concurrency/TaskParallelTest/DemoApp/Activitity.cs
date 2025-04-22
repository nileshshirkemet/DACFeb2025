class Activity
{
    public static long Perform(int count)
    {
        long seed = count;
        int goal = Environment.TickCount + 100 * count;
        while(Environment.TickCount < goal);
        return seed * count;
    }
}