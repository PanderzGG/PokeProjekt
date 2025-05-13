using PokeDex.Classes.Abilities.Main;
using PokeDex.Classes.Helper;
using PokeDex.Classes.Moves.Main;
using PokeDex.Classes.Pokedexes.Helper;
using PokeDex.Classes.Types.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.GenerationAndVersion
{
    public class Generation
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("abilities")]
        public List<Ability>? Abilities { get; set; }

        [JsonPropertyName("names")]
        public List<Name>? Names { get; set; }

        [JsonPropertyName("main_region")]
        public Region? MainRegion { get; set; }

        [JsonPropertyName("moves")]
        public List<Move>? Moves { get; set; }

        [JsonPropertyName("pokemon_species")]
        public List<PokemonSpecies>? PokemonSpecies { get; set; }

        [JsonPropertyName("types")]
        public List<PokemonType>? Types { get; set; }

        [JsonPropertyName("version_groups")]
        public List<VersionGroup>? VersionGroups { get; set; }
    }
}
