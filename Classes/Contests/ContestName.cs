using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Contests
{
    public class ContestName
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("color")]
        public string? Color { get; set; }
        [JsonPropertyName("language")]
        public Language? Language { get; set; }
    }
}
