using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokedex.Helper
{
    public class PokemonSpeciesVariety
    {
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
        [JsonPropertyName("pokemon")]
        public PokeDex.Classes.Pokemons.Main.Pokemon? Pokemon { get; set; }
    }
}
