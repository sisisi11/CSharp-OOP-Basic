using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

public abstract class Nation
{
    private ICollection<Bender> benders = new List<Bender>();
    private ICollection<Monument> monuments = new List<Monument>();
    private BigInteger totalPower = 0;
    private BigInteger bonusPowerPercents = 0;

    public BigInteger TotalPower { get { return this.totalPower; } set { this.totalPower = value; } }
    public BigInteger BonusPowerPercents { get { return this.bonusPowerPercents; } set { this.bonusPowerPercents = value; } }

    public void AddMonument(Monument monument)
    {
        this.monuments.Add(monument);
        this.bonusPowerPercents += monument.Affinity;
    }

    public void AddBender(Bender bender)
    {
        this.benders.Add(bender);
        this.totalPower += (BigInteger)bender.Power;
    }

    public void AddMonumentBonuses()
    {
        this.totalPower += (this.totalPower / 100) * this.bonusPowerPercents;
    }
    public void Destroy()
    {
        this.monuments.Clear();
        this.benders.Clear();
        this.totalPower = 0;
        this.bonusPowerPercents = 0;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        string nationType = this.GetType().Name.Replace("Nation", string.Empty);
        result.Append($"{nationType} Nation{Environment.NewLine}");

        // Append benders info
        result.Append("Benders:");
        result.Append(this.benders.Count == 0 ? $" None{Environment.NewLine}" : Environment.NewLine);

        foreach (var bender in this.benders)
        {
            result.Append($"###{bender}{Environment.NewLine}");
        }

        // Append monuments info
        result.Append("Monuments:");
        result.Append(this.monuments.Count == 0 ? $" None" : Environment.NewLine);

        foreach (var monument in this.monuments)
        {
            result.Append($"###{monument.ToString()}{Environment.NewLine}");
        }

        return result.ToString().Trim();
    }
}