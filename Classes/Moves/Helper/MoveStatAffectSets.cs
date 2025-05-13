using System.Text.Json.Serialization;

namespace PokeDex.Classes.Moves.Helper
{
    public class MoveStatAffectSets
    {
        [JsonPropertyName("increase")]
        public List<MoveStatAffect> Increase { get; set; }
        [JsonPropertyName("decrease")]
        public List<MoveStatAffect> Decrease { get; set; }
    }
}