using System.Text.Json.Serialization;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonCries
    {
        [JsonPropertyName("latest")]
        public string Latest { get; set; }
        [JsonPropertyName("legacy")]
        public string Legacy { get; set; }
    }
}