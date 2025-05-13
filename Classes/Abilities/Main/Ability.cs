using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Abilities.Main
{
    public class Ability
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_main_series")]
        public bool IsMainSeries { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}
