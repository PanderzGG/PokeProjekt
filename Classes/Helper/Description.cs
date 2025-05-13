using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Helper
{
    public class Description
    {
        [JsonPropertyName("description")]
        public string _Description { get; set; }
        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }
}
