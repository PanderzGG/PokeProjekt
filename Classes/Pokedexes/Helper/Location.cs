using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokedexes.Helper
{
    public class Location
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("region")]
        public Region Region { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }


        [JsonPropertyName("game_indices")]
        public List<GenerationGameIndex> GameIndices { get; set; }

        [JsonPropertyName("areas")]
        public List<LocationArea> Areas { get; set; }
    }
}
