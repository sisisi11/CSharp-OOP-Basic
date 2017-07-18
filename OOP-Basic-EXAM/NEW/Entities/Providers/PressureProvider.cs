using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) : base(id, energyOutput)
    {
        base.EnergyOutput += this.EnergyOutput / 2;
    }

}