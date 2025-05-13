using PokeDex.Classes.GenerationAndVersion;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Item.Helper
{
    public class PokemonHeldItemVersion
    {
        [JsonPropertyName("version")]
        public PokeVersion Version { get; set; }
        [JsonPropertyName("rarity")]
        public int Rarity { get; set; }
    }
}