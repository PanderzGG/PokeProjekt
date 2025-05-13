using PokeDex.Classes.Stats.Main;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonStat
    {
        [JsonPropertyName("stat")]
        public Stat Stat { get; set; }
        [JsonPropertyName("effort")]
        public int Effort { get; set; }
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
    }
}