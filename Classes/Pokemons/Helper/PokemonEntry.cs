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
    public class PokemonEntry
    {
        [JsonPropertyName("entry_number")]
        public int EntryNumber { get; set; }

        [JsonPropertyName("pokemon_species")]
        public PokemonSpecies PokemonSpecies { get; set; }
    }
}
