using PokeDex.Classes.Helper;
using PokeDex.Classes.Natures.Helper;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Stats.Helper
{
    public class PokeathlonStat
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
        [JsonPropertyName("affecting_natures")]
        public NaturePokeathlonStatAffectSets AffectingNatures { get; set; }
    }
}