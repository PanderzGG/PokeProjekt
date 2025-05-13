using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Types.Main;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Types.Helper
{
    public class PokemonTypePast
    {
        [JsonPropertyName("generation")]
        public Generation Generation { get; set; }
        [JsonPropertyName("types")]
        public List<PokemonType> Types { get; set; }
    }
}