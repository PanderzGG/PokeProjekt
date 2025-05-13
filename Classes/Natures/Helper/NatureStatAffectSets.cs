using System.Text.Json.Serialization;
using PokeDex.Classes.Natures.Main;

namespace PokeDex.Classes.Natures.Helper
{
    public class NatureStatAffectSets
    {
        [JsonPropertyName("increase")]
        public List<Nature> Increase { get; set; }
        [JsonPropertyName("decrease")]
        public List<Nature> Decrease { get; set; }
    }
}