using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using PokeDex.Classes.PalPark;
using PokeDex.Classes.Pokedex.Helper;
using PokeDex.Classes.Pokemon.Evolution;
using PokeDex.Classes.Pokemons.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PokeDex.Classes.Pokedexes.Helper
{
    public class PokemonSpecies
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("gender_rate")]
        public int GenderRate { get; set; }

        [JsonPropertyName("capture_rate")]
        public int CaptureRate { get; set; }

        [JsonPropertyName("base_happiness")]
        public int BaseHappiness { get; set; }

        [JsonPropertyName("is_baby")]
        public bool IsBaby { get; set; }

        [JsonPropertyName("is_legendary")]
        public bool IsLegendary { get; set; }

        [JsonPropertyName("is_mythical")]
        public bool IsMythical { get; set; }

        [JsonPropertyName("hatch_counter")]
        public int HatchCounter { get; set; }

        [JsonPropertyName("has_gender_differences")]
        public bool HasGenderDifferences { get; set; }

        [JsonPropertyName("forms_switchblade")]
        public bool FormsSwitchblade { get; set; }

        [JsonPropertyName("growth_rate")]
        public GrowthRate? GrowthRate { get; set; }

        [JsonPropertyName("pokedex_numbers")]
        public List<PokemonSpeciesDexEntry>? PokemonSpeciesDexEntry { get; set; }

        [JsonPropertyName("egg_groups")]
        public List<EggGroup>? EggGroups { get; set; }

        [JsonPropertyName("color")]
        public PokemonColor? Color { get; set; }

        [JsonPropertyName("shape")]
        public PokemonShape? Shape { get; set; }

        [JsonPropertyName("evolves_from_species")]
        public PokemonSpecies? EvolvesFromSpecies { get; set; }

        [JsonPropertyName("evolution_chain")]
        public EvolutionChain? EvolutionChain { get; set; }

        [JsonPropertyName("habitat")]
        public PokemonHabitat? Habitat { get; set; }

        [JsonPropertyName("generation")]
        public Generation? Generation { get; set; }

        [JsonPropertyName("names")]
        public List<Name>? Names { get; set; }

        [JsonPropertyName("pal_park_encounters")]
        public List<PalParkEncounterArea>? PalParkEncountersArea { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorText>? FlavorTexts { get; set; }

        [JsonPropertyName("form_descriptions")]
        public List<Description>? FormDescriptions { get; set; }

        [JsonPropertyName("genera")]
        public List<Genus>? Genera { get; set; }

        [JsonPropertyName("varieties")]
        public List<PokemonSpeciesVariety>? Varieties { get; set; }
    }
}
