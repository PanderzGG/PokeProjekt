using PokeDex.Classes.GenerationAndVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonEncounter
    {
        [JsonPropertyName("location_area")]
        public PokeDex.Classes.Pokemons.Main.Pokemon? Pokemon { get; set; }

        [JsonPropertyName("version_details")]
        public List<VersionEncounterDetail>? VersionEncounterDetails { get; set; }
    }
}
