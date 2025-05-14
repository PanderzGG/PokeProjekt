using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Contests
{
    public class ContestEffect
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("appeal")]
        public int Appeal { get; set; }
        [JsonPropertyName("jam")]
        public int Jam { get; set; }
        [JsonPropertyName("effect_entries")]
        public List<PokeDex.Classes.Effects.Effect> EffectEntries { get; set; }
        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorText> FlavorTextEntries { get; set; }
    }
}
