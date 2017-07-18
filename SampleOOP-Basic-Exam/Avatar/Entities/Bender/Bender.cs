using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Bender
{
    private string name;
    private double power;

    protected Bender(string name, double power)
    {
        this.name = name;
        this.power = power;
    }

    public virtual double Power { get { return this.power; } set { this.power = value; } }

    public override string ToString()
    {
        return $"{this.GetType().Name.Replace("Bender", string.Empty)} Bender: {this.name}, Power: {this.power}";
    }
}