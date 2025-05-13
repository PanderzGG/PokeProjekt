using PokeDex.Classes.GenerationAndVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Encounters.Helper
{
    public class EncounterVersionDetails
    {
        [JsonPropertyName("rate")]
        public int Rate { get; set; }

        [JsonPropertyName("version")]
        public PokeVersion Version { get; set; }
    }
}
