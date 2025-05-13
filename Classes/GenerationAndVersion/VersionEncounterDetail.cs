using PokeDex.Classes.Encounters.Main;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.GenerationAndVersion
{
    public class VersionEncounterDetail
    {
        [JsonPropertyName("version")]
        public PokeVersion Version { get; set; }

        [JsonPropertyName("max_chance")]
        public int MaxChance { get; set; }

        [JsonPropertyName("encounter_details")]
        public List<Encounter> Encounters { get; set; }
    }
}
