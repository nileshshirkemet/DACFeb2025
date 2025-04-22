class Activity
{
    public static void Perform(int count)
    {
        int goal = Environment.TickCount + 1000 * count;
        while(Environment.TickCount < goal);
    }
}