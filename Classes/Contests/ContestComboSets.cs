using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Contests
{
    public class ContestComboSets
    {
        [JsonPropertyName("normal")]
        public ContestComboDetail? Normal { get; set; }
        [JsonPropertyName("super")]
        public ContestComboDetail? Super { get; set; }
    }
}
