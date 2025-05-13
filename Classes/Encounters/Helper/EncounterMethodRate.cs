using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Encounters.Helper
{
    public class EncounterMethodRate
    {
        [JsonPropertyName("encounter_method")]
        public EncounterMethod EncounterMethod { get; set; }

        [JsonPropertyName("version_details")]
        public EncounterVersionDetails EncounterVersionDetails { get; set; }
    }
}
