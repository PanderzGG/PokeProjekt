using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.PalPark
{
    public class PalParkArea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
        [JsonPropertyName("pokemon_encounters")]
        public List<PalParkEncounterSpecies> PokemonEncounters { get; set; }
    }
}
