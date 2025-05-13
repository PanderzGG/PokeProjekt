using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Effects
{
    public class Effect
    {
        [JsonPropertyName("effect")]
        public string _Effect { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }
}
