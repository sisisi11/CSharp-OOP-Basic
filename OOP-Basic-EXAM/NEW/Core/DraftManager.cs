using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private string mode;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.mode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var msg = "";
        try
        {
            string type = arguments[0];
            string id = arguments[1];
            double oreOutput = double.Parse(arguments[2]);
            double energyRequirment = double.Parse(arguments[3]);

            switch (type)
            {
                case "Sonic":
                    int sonicFactor = int.Parse(arguments[4]);
                    harvesters[id] = new SonicHarvester(arguments[1], oreOutput, energyRequirment, sonicFactor);
                    return $"Successfully registered Sonic Harvester - {id}";
                    break;
                default:
                    harvesters[id] = new HammerHarvester(arguments[1], oreOutput, energyRequirment);
                    return $"Successfully registered Hammer Harvester - {id}";
                    break;
            }
        }
        catch (ArgumentException ae)
        {
            msg = ae.Message;
        }
        return msg;
    }
    public string RegisterProvider(List<string> arguments)
    {
        var msg = "";
        try
        {
            string type = arguments[0];
            string id = arguments[1];
            double energyOutput = double.Parse(arguments[2]);

            switch (type)
            {
                case "Solar":
                    providers[id] = new SolarProvider(id, energyOutput);
                    return $"Successfully registered Solar Provider - {id}";
                    break;
                default:
                    providers[id] = new PressureProvider(id, energyOutput);
                    return $"Successfully registered Pressure Provider - {id}";
                    break;
            }
        }
        catch (ArgumentException ae)
        {
            msg = ae.Message;
        }
        return msg;
    }
    public string Mode(List<string> arguments)
    {
        mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Day()
    {
        var sumHarvestEnergyThisDay = harvesters.Sum(h => h.Value.EnergyRequirement);
        var providerdEnergyThisDay = providers.Sum(p => p.Value.EnergyOutput);

        var plumbOre = 0d;

        this.totalStoredEnergy += providerdEnergyThisDay;
        if (mode == "Half")
        {
            sumHarvestEnergyThisDay = harvesters.Sum(h => h.Value.EnergyRequirement * 60 / 100);
            if (sumHarvestEnergyThisDay <= this.totalStoredEnergy)
            {
                var oreGrindedToday = harvesters.Sum(o => o.Value.OreOutput * 50 / 100);
                this.totalMinedOre += oreGrindedToday; // FOR SHUTDOW
                plumbOre = oreGrindedToday;
                this.totalStoredEnergy -= sumHarvestEnergyThisDay; // For SHutDown
            }
        }
        else if (mode == "Full")
        {
            if (sumHarvestEnergyThisDay <= this.totalStoredEnergy)
            {
                this.totalMinedOre += harvesters.Sum(o => o.Value.OreOutput); //Pazim totalMinedOre za ShutDown komandata
                plumbOre = harvesters.Sum(o => o.Value.OreOutput);  //Ore v tozi den
                this.totalStoredEnergy -= sumHarvestEnergyThisDay; //
            }
        }
        var sb = new StringBuilder();

        sb.AppendLine("A day has passed.").AppendLine($"Energy Provided: {providerdEnergyThisDay}")
            .AppendLine($"Plumbus Ore Mined: {plumbOre}");

        return sb.ToString().Trim();

    }
    public string Check(List<string> arguments)
    {
        string Id = arguments[0];
        if (harvesters.ContainsKey(Id))
        {
            if (harvesters[Id] is HammerHarvester)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Hammer Harvester - {Id}").
                    AppendLine($"Ore Output: {harvesters[Id].OreOutput}");
                sb.AppendLine($"Energy Requirement: {harvesters[Id].EnergyRequirement}");

                return sb.ToString().Trim();
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Sonic Harvester - {Id}").
                    AppendLine($"Ore Output: {harvesters[Id].OreOutput}");
                sb.AppendLine($"Energy Requirement: {harvesters[Id].EnergyRequirement}");

                return sb.ToString().Trim();
            }
        }
        if (providers.ContainsKey(Id))
        {
            if (providers[Id] is PressureProvider)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Pressure Provider - {Id}").
                    AppendLine($"Energy Output: {providers[Id].EnergyOutput}");

                return sb.ToString().Trim();
            }
            else
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Solar Provider - {Id}").
                    AppendLine($"Energy Output: {providers[Id].EnergyOutput}");

                return sb.ToString().Trim();
            }
        }
        return $"No element found with id - {Id}";
    }
    public string ShutDown()
    {
        var sb = new StringBuilder();

        sb.AppendLine("System Shutdown")
            .AppendLine($"Total Energy Stored: {this.totalStoredEnergy}")
            .AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString().Trim();
    }
}
