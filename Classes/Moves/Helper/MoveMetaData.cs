using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Moves.Helper
{
    public class MoveMetaData
    {
        [JsonPropertyName("ailment")]
        public MoveAilment? Ailment { get; set; }
        [JsonPropertyName("category")]
        public MoveCategory? Category { get; set; }
        [JsonPropertyName("min_hits")]
        public int? MinHits { get; set; }
        [JsonPropertyName("max_hits")]
        public int? MaxHits { get; set; }
        [JsonPropertyName("min_turns")]
        public int? MinTurns { get; set; }
        [JsonPropertyName("max_turns")]
        public int? MaxTurns { get; set; }
        [JsonPropertyName("drain")]
        public int? Drain { get; set; }
        [JsonPropertyName("healing")]
        public int? Healing { get; set; }
        [JsonPropertyName("crit_rate")]
        public int? CritRate { get; set; }
        [JsonPropertyName("ailment_chance")]
        public int? AilmentChance { get; set; }
        [JsonPropertyName("flinch_chance")]
        public int? FlinchChance { get; set; }
        [JsonPropertyName("stat_chance")]
        public int? StatChance { get; set; }
    }
}
