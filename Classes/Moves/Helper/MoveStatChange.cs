using PokeDex.Classes.Stats.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Moves.Helper
{
    public class MoveStatChange
    {
        [JsonPropertyName("change")]
        public int Change { get; set; }
        [JsonPropertyName("stat")]
        public Stat Stat { get; set; }
    }
}
