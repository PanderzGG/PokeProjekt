using PokeDex.Classes.Helper;
using PokeDex.Classes.Pokedex.Helper;
using PokeDex.Classes.Pokedexes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonHabitat
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
        [JsonPropertyName("pokemon_species")]
        public List<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
