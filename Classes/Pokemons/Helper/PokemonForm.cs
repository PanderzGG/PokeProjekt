using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using PokeDex.Classes.Pokemons.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonForm
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("order")]
        public int Order { get; set; }
        [JsonPropertyName("form_order")]
        public int FormOrder { get; set; }
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }
        [JsonPropertyName("is_battle_only")]
        public bool IsBattleOnly { get; set; }
        [JsonPropertyName("is_mega")]
        public bool IsMega { get; set; }
        [JsonPropertyName("form_name")]
        public string? FormName { get; set; }
        [JsonPropertyName("pokemon")]
        public PokeDex.Classes.Pokemons.Main.Pokemon? Pokemon { get; set; }
        [JsonPropertyName("types")]
        public List<PokemonFormType>? Types { get; set; }
        [JsonPropertyName("sprites")]
        public PokemonFormSprites? Sprites { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup? VersionGroup { get; set; }
        [JsonPropertyName("names")]
        public List<Name>? Names { get; set; }
        [JsonPropertyName("form_names")]
        public List<Name>? FormNames { get; set; }
    }
}
