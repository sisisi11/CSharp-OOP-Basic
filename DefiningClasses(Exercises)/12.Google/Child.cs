using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Child
{
    public string Name { get; set; }
    public string Birthday { get; set; }

    public Child(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Birthday}";
    }
}