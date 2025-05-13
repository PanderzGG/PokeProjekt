using PokeDex.Classes.Encounters.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Encounters.Main
{
    public class Encounter
    {
        [JsonPropertyName("min_level")]
        public int MinLevel { get; set; }

        [JsonPropertyName("max_level")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("condition_values")]
        public List<EncounterConditionValue> EncounterConditionValues { get; set; }

        [JsonPropertyName("chance")]
        public int Chance { get; set; }

        [JsonPropertyName("method")]
        public EncounterMethod Method { get; set; }
    }
}
