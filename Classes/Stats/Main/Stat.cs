using PokeDex.Classes.Helper;
using PokeDex.Classes.Moves.Helper;
using PokeDex.Classes.Natures.Helper;
using PokeDex.Classes.Pokemons.Main;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Stats.Main
{
    public class Stat
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }
        [JsonPropertyName("is_battle_only")]
        public bool IsBattleOnly { get; set; }
        [JsonPropertyName("affecting_moves")]
        public MoveStatAffectSets AffectingMoves { get; set; }
        [JsonPropertyName("affecting_natures")]
        public NatureStatAffectSets AffectingNatures { get; set; }
        [JsonPropertyName("characteristics")]
        public List<Characteristic> Characteristics { get; set; }
        [JsonPropertyName("move_damage_class")]
        public MoveDamageClass MoveDamageClass { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}