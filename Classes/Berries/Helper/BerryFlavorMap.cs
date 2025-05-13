using System.Text.Json.Serialization;

namespace PokeDex.Classes.Berries.Helper
{
    public class BerryFlavorMap
    {
        [JsonPropertyName("potency")]
        public int Potency { get; set; }
        [JsonPropertyName("flavor")]
        public BerryFlavor Flavor { get; set; }
    }
}