using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int[] inputArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int numberOfRectangles = inputArgs[0];
        int numberOfIntersectionChecks = inputArgs[1];

        Dictionary<string, Rectangle> rectanglesByIds = new Dictionary<string, Rectangle>();
        for (int i = 0; i < numberOfRectangles; i++)
        {
            string[] rectangleArgs = Console.ReadLine().Split();
            string id = rectangleArgs[0];
            double width = double.Parse(rectangleArgs[1]);
            double height = double.Parse(rectangleArgs[2]);
            double x = double.Parse(rectangleArgs[3]);
            double y = double.Parse(rectangleArgs[4]);

            rectanglesByIds.Add(id, new Rectangle(id, width, height, x, y));
        }

        for (int i = 0; i < numberOfIntersectionChecks; i++)
        {
            string[] commandArgs = Console.ReadLine().Split();
            Rectangle first = rectanglesByIds[commandArgs[0]];
            Rectangle second = rectanglesByIds[commandArgs[1]];

            if (first.IntersectionCheck(second))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}