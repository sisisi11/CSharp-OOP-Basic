using System;
using System.Collections.Generic;
using System.Linq;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private IList<string> issuedWars = new List<string>();

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>   {
            { "Air", new AirNation() },
            { "Water", new WaterNation() },
            { "Fire", new FireNation() },
            { "Earth", new EarthNation() },
        };
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        uint power = uint.Parse(benderArgs[2]);
        double secondayParameter = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "Fire":
                Bender fireBender = new FireBender(name, power, secondayParameter);
                this.nations["Fire"].AddBender(fireBender);
                break;
            case "Air":
                Bender airBender = new AirBender(name, power, secondayParameter);
                this.nations["Air"].AddBender(airBender);
                break;
            case "Earth":
                Bender earhBender = new EarthBender(name, power, secondayParameter);
                this.nations["Earth"].AddBender(earhBender);
                break;
            case "Water":
                Bender waBender = new WaterBender(name, power, secondayParameter);
                this.nations["Water"].AddBender(waBender);
                break;
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        int affinity = int.Parse(monumentArgs[2]);
        switch (type)
        {
            case "Fire":
                Monument fireMonument = new FireMonument(name, affinity);
                this.nations["Fire"].AddMonument(fireMonument);
                break;
            case "Air":
                Monument airMonument = new AirMonument(name, affinity);
                this.nations["Air"].AddMonument(airMonument);
                break;
            case "Earth":
                Monument earthMonument = new EarthMonument(name, affinity);
                this.nations["Earth"].AddMonument(earthMonument);
                break;
            case "Water":
                Monument waterMonument = new WaterMonument(name, affinity);
                this.nations["Water"].AddMonument(waterMonument);
                break;
        }

    }
    public string GetStatus(string nationsType)
    {
        return nations[nationsType].ToString();
    }
    public void IssueWar(string nationsType)
    {
        this.issuedWars.Add($"War {this.issuedWars.Count + 1} issued by {nationsType}");

        // Add monument bonuses to all nations
        foreach (var nationPair in this.nations)
        {
            nationPair.Value.AddMonumentBonuses();
        }

        // Destroy all defeated nations (destory all monuments and benders)
        var defeatedNations = this.nations.OrderByDescending(n => n.Value.TotalPower).Skip(1);
        foreach (var nationPair in defeatedNations)
        {
            nationPair.Value.Destroy();
        }
    }
    public string GetWarsRecord()
    {
        return string.Join("\n", this.issuedWars);
    }
}