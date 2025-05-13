using PokeDex.Classes.Pokedex.Helper;
using PokeDex.Classes.Pokedexes.Helper;
using PokeDex.Classes.Pokemon.Evolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes
{
    public class ChainLink
    {
        [JsonPropertyName("is_baby")]
        public bool IsBaby { get; set; }
        [JsonPropertyName("species")]
        public PokemonSpecies Species { get; set; }
        [JsonPropertyName("evolution_details")]
        public List<EvolutionDetail> EvolutionDetails { get; set; }
        [JsonPropertyName("evolves_to")]
        public List<ChainLink> EvolvesTo { get; set; }
    }
}
