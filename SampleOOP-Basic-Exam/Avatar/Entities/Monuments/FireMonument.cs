﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity) : base(name)
    {
        this.fireAffinity = fireAffinity;
    }

    public override int Affinity => this.fireAffinity;
}