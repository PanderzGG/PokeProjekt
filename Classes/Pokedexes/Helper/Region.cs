using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using PokeDex.Classes.Pokedexes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokedexes.Helper
{
    public class Region
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("locations")]
        public List<Location>? Locations { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("names")]
        public List<Name>? Names { get; set; }

        [JsonPropertyName("main_generation")]
        public Generation? MainGeneration { get; set; }

        [JsonPropertyName("pokedexes")]
        public List<PokeDex.Classes.Pokedexes.Main.Pokedex>? Pokedexs { get; set; }

        [JsonPropertyName("version_groups")]
        public List<VersionGroup>? VersionGroups { get; set; }
    }
}
