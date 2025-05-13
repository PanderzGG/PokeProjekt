using PokeDex.Classes.GenerationAndVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Helper
{
    public class FlavorText
    {
        [JsonPropertyName("flavor_text")]
        public string? _FlavorText { get; set; }
        [JsonPropertyName("language")]
        public Language? Language { get; set; }
        [JsonPropertyName("version")]
        public PokeVersion? Version { get; set; }
    }
}
