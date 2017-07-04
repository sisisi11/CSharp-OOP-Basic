using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cymric : Cat
{
    public double FlurLength { get; set; }

    public Cymric(string name, double flurLength)
        : base(name)
    {
        this.FlurLength = flurLength;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {this.FlurLength:F2}";
    }
}
