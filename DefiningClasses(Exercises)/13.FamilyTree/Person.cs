using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; }

    public string Birthday { get; }

    public List<Person> Parents { get; }

    public List<Person> Children { get; }

    public Person(string name, string birthDay)
    {
        this.Name = name;
        this.Birthday = birthDay;
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Birthday}";
    }
}