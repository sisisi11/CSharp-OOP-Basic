using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private DraftManager manager;

    public Engine()
    {
        this.manager = new DraftManager();
    }
    
    public void Run()
    {
        var tokens = Console.ReadLine().Split();

        while (tokens[0] != "Shutdown")
        {
            var command = tokens[0];

            List<string> arguments = tokens.Skip(1).ToList();
            switch (command)
            {
                case "RegisterHarvester":
                    var resultHarv = manager.RegisterHarvester(arguments);
                    Console.WriteLine(resultHarv);
                    break;
                case "RegisterProvider":
                    var resultProv = manager.RegisterProvider(arguments);
                    Console.WriteLine(resultProv);
                    break;
                case "Day":
                    Console.WriteLine(manager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(manager.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(manager.Check(arguments));
                    break;
            }

            tokens = Console.ReadLine().Split();
        }
        Console.WriteLine(manager.ShutDown());
    }
}