using PokeDex.Classes.Moves.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Contests
{
    public class ContestComboDetail
    {
        [JsonPropertyName("use_before")]
        public Move UseBefore { get; set; }
        [JsonPropertyName("use_after")]
        public Move UseAfter { get; set; }
    }
}
