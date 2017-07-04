using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat
{
    public string Name { get; set; }

    public Cat(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} {this.Name}";
    }
}
