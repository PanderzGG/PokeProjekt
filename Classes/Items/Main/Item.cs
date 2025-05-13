using PokeDex.Classes.Effect;
using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using PokeDex.Classes.Item.Helper;
using PokeDex.Classes.Item.Sprites;
using PokeDex.Classes.Pokemon.Evolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PokeDex.Classes.Items.Main
{
    public class Item
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("cost")]
        public int Cost { get; set; }
        [JsonPropertyName("fling_power")]
        public int FlingPower { get; set; }
        [JsonPropertyName("fling_effect")]
        public ItemFlingEffect ItemFlingEffect { get; set; }
        [JsonPropertyName("attributes")]
        public List<ItemAttribute> ItemAttributes { get; set; }
        [JsonPropertyName("category")]
        public ItemCollection ItemCategory { get; set; }
        [JsonPropertyName("effect_entries")]
        public List<VerboseEffect> EffectEntries { get; set; }
        [JsonPropertyName("flavor_text_entries")]
        public List<VersionGroupFlavorText> FlavorTextEntries { get; set; }
        [JsonPropertyName("game_indices")]
        public List<GenerationGameIndex> GameIndices { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
        [JsonPropertyName("sprites")]
        public ItemSprites Sprites { get; set; }
        [JsonPropertyName("held_by_pokemon")]
        public List<ItemHolderPokemon> HeldByPokemon { get; set; }
        [JsonPropertyName("baby_trigger_for")]
        public EvolutionChain BabyTriggerFor { get; set; }
        [JsonPropertyName("machines")]
        public List<MachineVersionDetail> Machines { get; set; }
    }
}
