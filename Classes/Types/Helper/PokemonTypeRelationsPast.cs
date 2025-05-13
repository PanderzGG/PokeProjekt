using PokeDex.Classes.GenerationAndVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Types.Helper
{
    public class PokemonTypeRelationsPast
    {
        [JsonPropertyName("generation")]
        public Generation Generation { get; set; }
        [JsonPropertyName("damage_relations")]
        public PokemonTypeRelations DamageRelations { get; set; }
    }
}
