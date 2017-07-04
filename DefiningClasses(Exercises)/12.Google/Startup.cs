using System;
using System.Collections.Generic;

public class Startup
{
    static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        Dictionary<string, Person> peopleByName = new Dictionary<string, Person>();

        string inputLine = Console.ReadLine();
        while (inputLine != "End")
        {
            string[] inputLineArgs = inputLine.Split();
            string personName = inputLineArgs[0];
            string command = inputLineArgs[1];

            if (!peopleByName.ContainsKey(personName))
            {
                peopleByName.Add(personName, new Person(personName));
            }

            switch (command)
            {
                case "company":
                    string companyName = inputLineArgs[2];
                    string department = inputLineArgs[3];
                    var salary = decimal.Parse(inputLineArgs[4]);
                    peopleByName[personName].Company = new Company(companyName, department, salary);
                    break;

                case "pokemon":
                    string pokemonName = inputLineArgs[2];
                    string pokemonType = inputLineArgs[3];
                    peopleByName[personName].Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                    break;

                case "parents":
                    string parentName = inputLineArgs[2];
                    string parentBirthday = inputLineArgs[3];
                    peopleByName[personName].Parents.Add(new Parent(parentName, parentBirthday));
                    break;

                case "children":
                    string childName = inputLineArgs[2];
                    string childBirthday = inputLineArgs[3];
                    peopleByName[personName].Children.Add(new Child(childName, childBirthday));
                    break;

                case "car":
                    string carModel = inputLineArgs[2];
                    int carSpeed = int.Parse(inputLineArgs[3]);
                    peopleByName[personName].Car = new Car(carModel, carSpeed);
                    break;
            }
            inputLine = Console.ReadLine();
        }
        var targetPerson = Console.ReadLine();
        Console.WriteLine(peopleByName[targetPerson]);
    }
}