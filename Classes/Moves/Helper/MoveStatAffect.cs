using PokeDex.Classes.Moves.Main;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Moves.Helper
{
    public class MoveStatAffect
    {
        [JsonPropertyName("change")]
        public int Change { get; set; }
        [JsonPropertyName("move")]
        public Move Move { get; set; }
    }
}