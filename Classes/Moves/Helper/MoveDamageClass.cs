using PokeDex.Classes.Helper;
using PokeDex.Classes.Moves.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Moves.Helper
{
    public class MoveDamageClass
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("descriptions")]
        public List<Description> Descriptions { get; set; }
        [JsonPropertyName("moves")]
        public List<Move> Moves { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}
