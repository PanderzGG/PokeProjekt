using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Items.Main;
using PokeDex.Classes.Moves.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes
{
    public class Machine
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("item")]
        public PokeDex.Classes.Items.Main.Item Item { get; set; }
        [JsonPropertyName("move")]
        public Move Move { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup VersionGroup { get; set; }
    }
}
