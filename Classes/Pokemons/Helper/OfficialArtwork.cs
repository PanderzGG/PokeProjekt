using System.Text.Json.Serialization;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class OfficialArtwork
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        public string FrontShiny { get; set; }

        public OfficialArtwork()
        {

        }
    }
}