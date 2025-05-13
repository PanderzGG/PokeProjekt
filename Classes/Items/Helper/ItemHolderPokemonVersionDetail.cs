using PokeDex.Classes.GenerationAndVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Item.Helper
{
    public class ItemHolderPokemonVersionDetail
    {
        [JsonPropertyName("rarity")]
        public int Rarity { get; set; }
        [JsonPropertyName("version")]
        public PokeVersion Version { get; set; }
    }
}
