using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Helper
{
    public class Name
    {
        [JsonPropertyName("name")]
        public string _Name { get; set; }
        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }
}
