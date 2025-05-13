using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Abilities.Main
{
    public class AbilityPokemon
    {
        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }
        [JsonPropertyName("slot")]
        public int Slot { get; set; }
        [JsonPropertyName("pokemon")]
        public PokeDex.Classes.Pokemons.Main.Pokemon? Pokemon { get; set; }
    }
}
