using PokeDex.Classes.Berries.Helper;
using PokeDex.Classes.Helper;
using PokeDex.Classes.Moves.Helper;
using PokeDex.Classes.Natures.Helper;
using PokeDex.Classes.Stats.Main;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Natures.Main
{
    public class Nature
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("decreased_stat")]
        public Stat DecreasedStat { get; set; }
        [JsonPropertyName("increased_stat")]
        public Stat IncreasedStat { get; set; }
        [JsonPropertyName("hates_flavor")]
        public BerryFlavor HatesFlavor { get; set; }
        [JsonPropertyName("likes_flavor")]
        public BerryFlavor LikesFlavor { get; set; }
        [JsonPropertyName("pokeathlon_stat_changes")]
        public List<NatureStatChange> PokeathlonStatChanges { get; set; }
        [JsonPropertyName("move_battle_style_preferences")]
        public List<MoveBattleStylePreference> MoveBattleStylePreferences { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}