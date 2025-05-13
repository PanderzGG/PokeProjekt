using System.Text.Json.Serialization;

namespace PokeDex.Classes.Moves.Helper
{
    public class MoveBattleStylePreference
    {
        [JsonPropertyName("low_hp_preference")]
        public int LowHpPreference { get; set; }
        [JsonPropertyName("high_hp_preference")]
        public int HighHpPreference { get; set; }
        [JsonPropertyName("move_battle_style")]
        public MoveBattleStyle MoveBattleStyle { get; set; }
    }
}