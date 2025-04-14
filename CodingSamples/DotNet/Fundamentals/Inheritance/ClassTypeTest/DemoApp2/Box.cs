struct Box
{
    public float Length { get; set; }

    public float Breadth { get; set; }

    public float Height { get; set; }

    public double Volume()
    {
        return Length * Breadth * Height;
    }

    public override string ToString()
    {
        //constructing interpolated string from variables
        return $"{Length} x {Breadth} x {Height}";
    }
}