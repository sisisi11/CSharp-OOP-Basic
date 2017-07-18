using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, double power, double waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public double WaterClarity { get { return this.waterClarity; } set { this.waterClarity = value; } }

    public override double Power => base.Power * this.waterClarity;

    public override string ToString()
    {
        return $"{base.ToString()}, Water Clarity: {this.WaterClarity:F2}";
    }
}