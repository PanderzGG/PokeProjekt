using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.PalPark
{
    public class PalParkEncounterArea
    {
        [JsonPropertyName("base_score")]
        public int BaseScore { get; set; }
        [JsonPropertyName("rate")]
        public int Rate { get; set; }
        [JsonPropertyName("area")]
        public PalParkArea Area { get; set; }
    }
}
