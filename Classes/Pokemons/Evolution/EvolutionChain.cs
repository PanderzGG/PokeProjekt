using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemon.Evolution
{
    public class EvolutionChain
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("baby_trigger_item")]
        public PokeDex.Classes.Items.Main.Item BabyTriggerItem { get; set; }
        [JsonPropertyName("chain")]
        public ChainLink Chain { get; set; }
    }
}
