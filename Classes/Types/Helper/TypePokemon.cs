using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PokeDex.Classes.Pokemons.Main;

namespace PokeDex.Classes.Type.Helper
{
    public class TypePokemon
    {
        [JsonPropertyName("slot")]
        public int Slot { get; set; }
        [JsonPropertyName("pokemon")]
        public PokeDex.Classes.Pokemons.Main.Pokemon? Pokemon { get; set; }
    }
}
