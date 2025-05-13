using System.Text.Json.Serialization;

namespace PokeDex.Classes.Natures.Helper
{
    public class NaturePokeathlonStatAffectSets
    {
        [JsonPropertyName("increase")]
        public List<NaturePokeathlonStatAffect> Increase { get; set; }
        [JsonPropertyName("decrease")]
        public List<NaturePokeathlonStatAffect> Decrease { get; set; }
    }
}