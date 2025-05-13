using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Contests
{
    public class ContestType
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        // Can implement Berries here but I ain't dong that rn
        // [JsonPropertyName("")]
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}
