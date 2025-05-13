using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Encounters.Helper
{
    public class EncounterConditionValue
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("condition")]
        public EncounterCondition EncounterCondition { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}
