using PokeDex.Classes.Berries.Main;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Berries.Helper
{
    public class FlavorBerryMap
    {
        [JsonPropertyName("potency")]
        public int Potency { get; set; }
        [JsonPropertyName("berry")]
        public Berry Berry { get; set; }
    }
}