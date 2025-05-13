using PokeDex.Classes.GenerationAndVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Abilities.Helpers
{
    public class AbilityEffectChange
    {
        [JsonPropertyName("effect_entries")]
        public List<PokeDex.Classes.Effects.Effect>? EffectEntries { get; set; }

        [JsonPropertyName("version_group")]
        public VersionGroup? VersionGroup { get; set; }
    }
}
