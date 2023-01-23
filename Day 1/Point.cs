namespace Lab1;

public class Point : IComparable<Point>, ICloneable
{
    public int X { get; set; }

    public int Y { get; set; }

    public string Name { get; set; }

    public object Clone()
    {
        return new Point
        {
            X = this.X + 2,
            Y = this.Y + 2,
            Name = $"{this.Name}-Clone"
        };
    }

    public int CompareTo(Point obj)
    {
        return this.X.CompareTo(obj.X);
    }

    public override string ToString()
    {
        return $"{Name} X: {X} - Y: {Y}";
    }
}
