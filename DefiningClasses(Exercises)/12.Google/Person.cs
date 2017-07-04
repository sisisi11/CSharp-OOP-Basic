using System.Collections.Generic;
using System.Text;

public class Person
{
    public string Name { get; set; }
    public Company Company { get; set; }
    public Car Car { get; set; }
    public ICollection<Pokemon> Pokemons { get; set; }
    public ICollection<Parent> Parents { get; set; }
    public ICollection<Child> Children { get; set; }

    public Person(string name)
    {
        this.Name = name;
        this.Pokemons = new List<Pokemon>();
        this.Parents = new List<Parent>();
        this.Children = new List<Child>();
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        // Append Name
        result.AppendLine(this.Name);

        //Append Company
        result.AppendLine("Company:");
        if (this.Company != null)
        {
            result.AppendLine(this.Company.ToString());
        }

        //Append Car
        result.AppendLine("Car:");
        if (this.Car != null)
        {
            result.AppendLine(this.Car.ToString());
        }

        //Add Pokemons
        result.AppendLine("Pokemon:");
        foreach (var pokemon in this.Pokemons)
        {
            result.AppendLine(pokemon.ToString());
        }

        // Append parents info
        result.AppendLine("Parents:");
        foreach (Parent parent in this.Parents)
        {
            result.AppendLine(parent.ToString());
        }

        // Append children info
        result.AppendLine("Children:");
        foreach (Child child in this.Children)
        {
            result.AppendLine(child.ToString());
        }

        return result.ToString();
    }
}