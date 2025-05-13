using PokeDex.Classes.Pokedexes.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokedexes.Helper
{
    public class PokemonSpeciesDexEntry
    {
        [JsonPropertyName("entry_number")]
        public int EntryNumber { get; set; }

        [JsonPropertyName("pokedex")]
        public PokeDex.Classes.Pokedexes.Main.Pokedex? Pokedex { get; set; }
    }
}
