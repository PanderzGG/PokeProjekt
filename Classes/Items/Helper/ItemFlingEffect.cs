using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Item.Helper
{
    public class ItemFlingEffect
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("effect_entries")]
        public List<PokeDex.Classes.Effects.Effect> EffectEntries { get; set; }
        [JsonPropertyName("items")]
        public List<PokeDex.Classes.Items.Main.Item> Items { get; set; }
    }
}
