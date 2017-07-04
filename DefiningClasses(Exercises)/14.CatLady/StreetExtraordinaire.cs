using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StreetExtraordinaire : Cat
{
    public int Decibels { get; set; }

    public StreetExtraordinaire(string name, int decibels)
        : base(name)
    {
        this.Decibels = decibels;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {this.Decibels}";
    }
}