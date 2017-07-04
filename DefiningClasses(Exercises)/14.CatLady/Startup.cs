using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Startup
{
    public static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        Dictionary<string, Cat> catsByName = new Dictionary<string, Cat>();

        string inputLine = Console.ReadLine();
        while (inputLine != "End")
        {
            string[] inputLineArgs = inputLine.Split();
            string catType = inputLineArgs[0];
            string catName = inputLineArgs[1];

            switch (catType)
            {
                case "Siamese":
                    int earSize = int.Parse(inputLineArgs[2]);
                    catsByName.Add(catName, new Siamese(catName, earSize));
                    break;
                case "Cymric":
                    double furLength = double.Parse(inputLineArgs[2]);
                    catsByName.Add(catName, new Cymric(catName, furLength));
                    break;
                case "StreetExtraordinaire":
                    int decibels = int.Parse(inputLineArgs[2]);
                    catsByName.Add(catName, new StreetExtraordinaire(catName, decibels));
                    break;
            }
            inputLine = Console.ReadLine();
        }

        string targetCat = Console.ReadLine();
        Console.WriteLine(catsByName[targetCat]);
    }
}