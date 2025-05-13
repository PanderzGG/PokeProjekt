using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Item.Helper
{
    public class PokemonHeldItem 
    {
        [JsonPropertyName("item")]
        public PokeDex.Classes.Items.Main.Item Item { get; set; }
        [JsonPropertyName("version_details")]
        public List<PokemonHeldItemVersion> VersionDetails { get; set; }
    }
}
