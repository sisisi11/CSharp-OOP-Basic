﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.airAffinity = airAffinity;
    }

    public override int Affinity => this.airAffinity;
}