using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PokeDex.Classes.Encounters.Helper;
using PokeDex.Classes.Pokemons.Helper;

namespace PokeDex.Classes.Pokedexes.Helper
{
    public class LocationArea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }

        [JsonPropertyName("encounter_method_rates")]
        public List<EncounterMethodRate> EncounterMethodRates { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }

        [JsonPropertyName("pokemon_encounters")]
        public List<PokemonEncounter> PokemonEncounters { get; set; }
    }
}
