using PokeDex.Classes.Natures.Main;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Natures.Helper
{
    public class NaturePokeathlonStatAffect
    {
        [JsonPropertyName("max_change")]
        public int MaxChange { get; set; }
        [JsonPropertyName("nature")]
        public Nature Nature { get; set; }
    }
}