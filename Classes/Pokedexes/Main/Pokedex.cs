using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using PokeDex.Classes.Pokedex.Helper;
using PokeDex.Classes.Pokedexes.Helper;
using PokeDex.Classes.Pokemons.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokedexes.Main
{
    public class Pokedex
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_main_series")]
        public bool IsMainSeries { get; set; }

        [JsonPropertyName("descriptions")]
        public List<Description> Descriptions { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }

        [JsonPropertyName("pokemon_entries")]
        public List<PokemonEntry> PokemonEntries { get; set; }

        [JsonPropertyName("region")]
        public Region Region { get; set; }

        [JsonPropertyName("version_groups")]
        public List<VersionGroup> VersionGroups { get; set; }
    }
}
