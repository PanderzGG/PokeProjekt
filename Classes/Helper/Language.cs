using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Helper
{
    public class Language
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("official")]
        public bool Official { get; set; }

        [JsonPropertyName("iso639")]
        public string Iso639 { get; set; }

        [JsonPropertyName("iso3166")]
        public string Iso3166 { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}
