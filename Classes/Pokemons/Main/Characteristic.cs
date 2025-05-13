using PokeDex.Classes.Helper;
using PokeDex.Classes.Stats.Main;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Pokemons.Main
{
    public class Characteristic
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("gene_modulo")]
        public int GeneModulo { get; set; }
        [JsonPropertyName("possible_values")]
        public List<int>? PossibleValues { get; set; }
        [JsonPropertyName("highest_stat")]
        public Stat? HighestStat { get; set; }
        [JsonPropertyName("descriptions")]
        public List<Description>? Descriptions { get; set; }
    }
}