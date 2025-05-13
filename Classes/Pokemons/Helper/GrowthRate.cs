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
    public class GrowthRate
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("formula")]
        public string? Formula { get; set; }
        [JsonPropertyName("descriptions")]
        public List<Description>? Descriptions { get; set; }
        [JsonPropertyName("levels")]
        public List<GrowthRateExperienceLevel>? Levels { get; set; }

        [JsonPropertyName("pokemon_species")]
        public List<PokemonSpecies>? PokemonSpecies { get; set; }
    }
}
