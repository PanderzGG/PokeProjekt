using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Effect
{
    public class VerboseEffect
    {
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("short_effect")]
        public string ShortEffect { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }
}
