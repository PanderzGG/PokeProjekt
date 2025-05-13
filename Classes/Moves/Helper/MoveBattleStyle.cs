using PokeDex.Classes.Helper;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Moves.Helper
{
    public class MoveBattleStyle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}