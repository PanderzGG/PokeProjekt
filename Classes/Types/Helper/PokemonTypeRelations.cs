using PokeDex.Classes.Types.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Types.Helper
{
    public class PokemonTypeRelations
    {
        [JsonPropertyName("no_damage_to")]
        public List<PokemonType> NoDamageTo { get; set; }
        [JsonPropertyName("half_damage_to")]
        public List<PokemonType> HalfDamageTo { get; set; }
        [JsonPropertyName("double_damage_to")]
        public List<PokemonType> DoubleDamageTo { get; set; }
        [JsonPropertyName("no_damage_from")]
        public List<PokemonType> NoDamageFrom { get; set; }
        [JsonPropertyName("half_damage_from")]
        public List<PokemonType> HalfDamageFrom { get; set; }
        [JsonPropertyName("double_damage_from")]
        public List<PokemonType> DoubleDamageFrom { get; set; }
    }
}
