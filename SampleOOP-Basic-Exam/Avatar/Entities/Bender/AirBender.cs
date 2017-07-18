using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AirBender : Bender
{
    private double aerialIntegrity;
    public AirBender(string name, double power, double aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity
    {
        get
        {
            return this.aerialIntegrity;
        }
        set
        {
            this.aerialIntegrity = value;
        }
    }
    public override double Power => base.Power * this.aerialIntegrity;

    public override string ToString()
    {
        return $"{base.ToString()}, Aerial Integrity: {this.AerialIntegrity:F2}";
    }
}