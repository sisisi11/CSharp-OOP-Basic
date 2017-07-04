using System;

class Startup
{
    public static void Main()
    {
        string targetFigure = Console.ReadLine();
        int width = int.Parse(Console.ReadLine());
        CorDraw corDraw;

        if (targetFigure == "Rectangle")
        {
            int height = int.Parse(Console.ReadLine());
            corDraw = new CorDraw(new Rectangle(width, height));
        }
        else
        {
            corDraw = new CorDraw(new Square(width));
        }

        corDraw.DrawFigure();
    }
}