using PokeDex.Classes.Moves.Main;
using PokeDex.Classes.Pokedex.Helper;
using PokeDex.Classes.Pokedexes.Helper;
using PokeDex.Classes.Types.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemon.Evolution
{
    public class EvolutionDetail
    {
        [JsonPropertyName("item")]
        public PokeDex.Classes.Items.Main.Item Item { get; set; }
        [JsonPropertyName("trigger")]
        public EvolutionTrigger Trigger { get; set; }
        [JsonPropertyName("gender")]
        public int Gender { get; set; }
        [JsonPropertyName("held_item")]
        public PokeDex.Classes.Items.Main.Item HeldItem { get; set; }
        [JsonPropertyName("known_move")]
        public Move KnownMove { get; set; }
        [JsonPropertyName("known_move_type")]
        public PokemonType KnownMoveType { get; set; }
        [JsonPropertyName("location")]
        public Location Location { get; set; }
        [JsonPropertyName("min_level")]
        public int MinLevel { get; set; }
        [JsonPropertyName("min_happiness")]
        public int MinHappiness { get; set; }
        [JsonPropertyName("min_beauty")]
        public int MinBeauty { get; set; }
        [JsonPropertyName("min_affection")]
        public int MinAffection { get; set; }
        [JsonPropertyName("needs_overworld_rain")]
        public bool NeedsOverworldRain { get; set; }
        [JsonPropertyName("perty_species")]
        public PokemonSpecies PartySpecies { get; set; }
        [JsonPropertyName("party_type")]
        public PokemonType PartyType { get; set; }
        [JsonPropertyName("relative_physical_stats")]
        public int RelativePhysicalStats { get; set; }
        [JsonPropertyName("time_of_day")]
        public string TimeOfDay { get; set; }
        [JsonPropertyName("trade_species")]
        public PokemonSpecies TradeSpecies { get; set; }
        [JsonPropertyName("turn_upside_down")]
        public bool TurnUpsideDown { get; set; }
    }
}
