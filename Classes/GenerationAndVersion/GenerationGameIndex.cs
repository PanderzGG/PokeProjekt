using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.GenerationAndVersion
{
    public class GenerationGameIndex
    {
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }

        [JsonPropertyName("generation")]
        public Generation Generation { get; set; }
    }
}
