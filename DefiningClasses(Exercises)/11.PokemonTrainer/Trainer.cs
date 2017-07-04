using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public ICollection<Pokemon> Pokemons { get; set; }

    public Trainer(string name)
    {
        this.Name = name;
        this.Badges = 0;
        this.Pokemons = new List<Pokemon>();
    }

    public bool HasPokemonWithElement(string element)
    {
        return this.Pokemons.Any(p => p.Element == element);
    }

    public void DamagePokemons()
    {
        foreach (var pokemon in this.Pokemons)
        {
            pokemon.Health -= 10;
        }

        this.FilterDeadPokemons();
    }

    private void FilterDeadPokemons()
    {
        this.Pokemons = this.Pokemons.Where(p => p.Health > 0).ToList();
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
    }
}