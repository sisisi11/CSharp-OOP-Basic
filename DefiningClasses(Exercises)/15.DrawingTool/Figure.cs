using System;

public abstract class Figure
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Figure(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public void Draw()
    {
        for (int row = 0; row < this.Height; row++)
        {
            if (row == 0 || row == this.Height - 1)
            {
                Console.WriteLine($"|{new string('-', this.Width)}|");
            }
            else
            {
                Console.WriteLine($"|{new string(' ', this.Width)}|");
            }
        }
    }
}