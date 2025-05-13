using PokeDex.Classes.Stats.Helper;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Natures.Helper
{
    public class NatureStatChange
    {
        [JsonPropertyName("max_change")]
        public int MaxChange { get; set; }
        [JsonPropertyName("pokeathlon_stat")]
        public PokeathlonStat PokeathlonStat { get; set; }
    }
}