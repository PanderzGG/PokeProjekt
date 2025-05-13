using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class Genus
    {
        [JsonPropertyName("genus")]
        public string _Genus { get; set; }
        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }
}
