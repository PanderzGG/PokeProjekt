using PokeDex.Classes.Abilities.Helpers;
using PokeDex.Classes.Contests;
using PokeDex.Classes.Effect;
using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using PokeDex.Classes.Moves.Helper;
using PokeDex.Classes.Stats.Helper;
using PokeDex.Classes.Types.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Moves.Main
{
    public class Move
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("accuracy")]
        public int Accuracy { get; set; }
        [JsonPropertyName("effect_chance")]
        public int EffectChance { get; set; }
        [JsonPropertyName("pp")]
        public int PP { get; set; }
        [JsonPropertyName("priority")]
        public int Priority { get; set; }
        [JsonPropertyName("power")]
        public int Power { get; set; }
        [JsonPropertyName("contest_combos")]
        public ContestComboSets? ContestCombos { get; set; }
        [JsonPropertyName("contest_type")]
        public ContestType? ContestType { get; set; }
        [JsonPropertyName("damage_class")]
        public MoveDamageClass? DamageClass { get; set; }
        [JsonPropertyName("effect_entries")]
        public List<VerboseEffect>? VerboseEffects { get; set; }
        [JsonPropertyName("effect_changes")]
        public List<AbilityEffectChange>? EffectChanges { get; set; }
        [JsonPropertyName("learned_by_pokemon")]
        public List<PokeDex.Classes.Pokemons.Main.Pokemon>? LearnedByPokemon { get; set; }
        [JsonPropertyName("flavor_text_entries")]
        public List<MoveFlavorText>? MoveFlavorTexts { get; set; }
        [JsonPropertyName("generation")]
        public Generation? Generation { get; set; }
        [JsonPropertyName("machines")]
        public List<MachineVersionDetail>? Machines { get; set; }
        [JsonPropertyName("meta")]
        public MoveMetaData? Meta { get; set; }

        [JsonPropertyName("names")]
        public List<Name>? Names { get; set; }
        [JsonPropertyName("past_values")]
        public List<PastMoveStatValues>? PastValues { get; set; }
        [JsonPropertyName("stat_changes")]
        public List<MoveStatChange>? StatChanges { get; set; }
        [JsonPropertyName("super_contest_effect")]
        public SuperContestEffect? SuperContestEffect { get; set; }
        [JsonPropertyName("target")]
        public MoveTarget? Target { get; set; }
        [JsonPropertyName("type")]
        public PokemonType? Type { get; set; }
    }
}
