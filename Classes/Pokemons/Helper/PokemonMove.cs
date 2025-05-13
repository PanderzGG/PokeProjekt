using PokeDex.Classes.Moves.Main;
using PokeDex.Classes.Pokemons.Helper;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonMove
    {
        [JsonPropertyName("move")]
        public Move? Move { get; set; }
        [JsonPropertyName("version_group_details")]
        public List<PokemonMoveVersion>? VersionGroupDetails { get; set; }
    }
}