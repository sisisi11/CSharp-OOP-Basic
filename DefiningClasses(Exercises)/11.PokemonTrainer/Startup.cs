using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Startup
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        Dictionary<string, Trainer> trainersByName = new Dictionary<string, Trainer>();

        while (inputLine != "Tournament")
        {
            string[] inputLineArgs = inputLine.Split();

            string trainerName = inputLineArgs[0];
            string pokemonName = inputLineArgs[1];
            string pokemonElement = inputLineArgs[2];
            int pokemonHealth = int.Parse(inputLineArgs[3]);

            Trainer trainer = new Trainer(trainerName);
            if (!trainersByName.ContainsKey(trainerName))
            {
                trainersByName.Add(trainerName, trainer);
            }

            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            trainersByName[trainerName].Pokemons.Add(pokemon);

            inputLine = Console.ReadLine();
        }

        string targetElement = Console.ReadLine();
        while (targetElement != "End")
        {
            foreach (var kvp in trainersByName)
            {
                if (kvp.Value.HasPokemonWithElement(targetElement))
                {
                    kvp.Value.Badges++;
                }
                else
                {
                    kvp.Value.DamagePokemons();
                }
            }

            targetElement = Console.ReadLine();
        }

        foreach (var trainer in trainersByName.OrderByDescending(t => t.Value.Badges))
        {
            Console.WriteLine(trainer.Value);
        }
    }
}