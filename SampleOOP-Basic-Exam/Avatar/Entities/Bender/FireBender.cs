using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, double power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }
    public double HeatAggression { get { return this.heatAggression; } set { this.heatAggression = value; } }
    public override double Power => base.Power * this.heatAggression;

    public override string ToString()
    {
       return $"{base.ToString()}, Heat Aggression: {this.HeatAggression:F2}";
    }
}