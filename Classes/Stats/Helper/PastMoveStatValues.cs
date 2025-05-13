using PokeDex.Classes.Effect;
using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Types.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Stats.Helper
{
    public class PastMoveStatValues
    {
        [JsonPropertyName("accuracy")]
        public int Accuracy { get; set; }
        [JsonPropertyName("effect_chance")]
        public int EffectChance { get; set; }
        [JsonPropertyName("power")]
        public int Power { get; set; }
        [JsonPropertyName("pp")]
        public int PP { get; set; }
        [JsonPropertyName("effect_entries")]
        public List<VerboseEffect>? EffectEntries { get; set; }
        [JsonPropertyName("type")]
        public PokemonType? Type { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup? VersionGroup { get; set; }
    }
}
