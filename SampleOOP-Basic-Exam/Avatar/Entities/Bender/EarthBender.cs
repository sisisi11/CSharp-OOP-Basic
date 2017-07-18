using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, double power, double groundSaturation) : base(name, power)
    {
        this.groundSaturation = groundSaturation;
    }

    public double GroundSaturation { get { return this.groundSaturation; } set { this.groundSaturation = value; } }

    public override double Power => base.Power * this.groundSaturation;

    public override string ToString()
    {
        return $"{base.ToString()}, Ground Saturation: {this.GroundSaturation:F2}";
    }
}