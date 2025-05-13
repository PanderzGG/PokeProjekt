using PokeDex.Classes.Moves.Helper;
using PokeDex.Classes.Pokedex.Helper;
using PokeDex.Classes.Pokedexes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.GenerationAndVersion
{
    public class VersionGroup
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("generation")]
        public Generation? Generation { get; set; }

        [JsonPropertyName("move_learn_methods")]
        public List<MoveLearnMethod>? MoveLearnMethods { get; set; }

        [JsonPropertyName("pokedexes")]
        public List<PokeDex.Classes.Pokedexes.Main.Pokedex>? Pokedexes { get; set; }

        [JsonPropertyName("regions")]
        public List<Region>? Regions { get; set; }

        [JsonPropertyName("versions")]
        public List<PokeVersion>? Versions { get; set; }
    }
}
