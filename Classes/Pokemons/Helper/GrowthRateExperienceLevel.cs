using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class GrowthRateExperienceLevel
    {
        [JsonPropertyName("level")]
        public int Level { get; set; }
        [JsonPropertyName("experience")]
        public int Experience { get; set; }
    }
}
