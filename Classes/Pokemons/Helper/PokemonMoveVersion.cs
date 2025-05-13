using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Moves.Helper;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonMoveVersion
    {
        [JsonPropertyName("move_learn_method")]
        public MoveLearnMethod? MoveLearnMethod { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup? VersionGroup { get; set; }
        [JsonPropertyName("level_learned_at")]
        public int LevelLearnedAt { get; set; }
        [JsonPropertyName("order")]
        public int? Order { get; set; }
    }
}