using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Moves.Helper
{
    public class MoveFlavorText
    {
        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }
        [JsonPropertyName("language")]
        public Language Language { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup VersionGroup { get; set; }
    }
}
