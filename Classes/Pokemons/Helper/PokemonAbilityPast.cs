using PokeDex.Classes.GenerationAndVersion;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonAbilityPast
    {
        [JsonPropertyName("generation")]
        public Generation Generation { get; set; }
        [JsonPropertyName("abilities")]
        public List<PokemonAbility> Abilities { get; set; }
    }
}