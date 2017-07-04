using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public string Weight { get; set; }
    public string Color { get; set; }

    public Car(string model, Engine engine, string weight = "n/a", string color = "n/a")
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = color;
    }


    public override string ToString()
    {
        return $@"{this.Model}:
  {this.Engine.Model}:
    Power: {this.Engine.Power}
    Displacement: {this.Engine.Displacement}
    Efficiency: {this.Engine.Efficiency}
  Weight: {this.Weight}
  Color: {this.Color}
";
    }
}