using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Item.Helper
{
    public class ItemHolderPokemon
    {
        [JsonPropertyName("pokemon")]
        public PokeDex.Classes.Pokemons.Main.Pokemon? Pokemon { get; set; }
        [JsonPropertyName("version_details")]
        public List<ItemHolderPokemonVersionDetail>? VersionDetails { get; set; }
    }
}
