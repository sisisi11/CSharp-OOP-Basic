public class Rectangle
{
    public string Name { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public Rectangle(string name, double width, double height, double x, double y)
    {
        this.Name = name;
        this.Width = width;
        this.Height = height;
        this.X = x;
        this.Y = y;
    }

    public bool IntersectionCheck(Rectangle rect)
    {
        return !(this.X > rect.X + rect.Width ||
                 this.X + this.Width < rect.X ||
                 this.Y > rect.Y + rect.Height ||
                 this.Y + this.Height < rect.Y);
    }
}