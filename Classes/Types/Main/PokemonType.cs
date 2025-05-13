using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using PokeDex.Classes.Moves.Helper;
using PokeDex.Classes.Moves.Main;
using PokeDex.Classes.Type.Helper;
using PokeDex.Classes.Types.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Types.Main
{
    public class PokemonType
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("damage_relations")]
        public PokemonTypeRelations? DamageRelations { get; set; }

        [JsonPropertyName("past_damage_relations")]
        public List<PokemonTypeRelationsPast>? PastDamageRelations { get; set; }
        [JsonPropertyName("game_indices")]
        public List<GenerationGameIndex>? GamesIndices { get; set; }
        [JsonPropertyName("generation")]
        public Generation? Generation { get; set; }
        [JsonPropertyName("move_damage_class")]
        public MoveDamageClass? MoveDamageClass { get; set; }
        [JsonPropertyName("names")]
        public List<Name>? Names { get; set; }
        [JsonPropertyName("pokemon")]
        public List<TypePokemon>? Pokemon { get; set; }
        [JsonPropertyName("moves")]
        public List<Move>? Moves { get; set; }
    }
}
