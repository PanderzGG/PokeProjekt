using PokeDex.Classes.Helper;
using PokeDex.Classes.Moves.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Contests
{
    public class SuperContestEffect
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("appeal")]
        public int Appeal { get; set; }
        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorText> FlavorTextEntries { get; set; }
        [JsonPropertyName("moves")]
        public List<Move> Moves { get; set; }
    }
}
