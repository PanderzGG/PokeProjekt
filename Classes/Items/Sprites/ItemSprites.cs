using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Item.Sprites
{
    public class ItemSprites
    {
        [JsonPropertyName("default")]
        public string Default { get; set; }
    }
}
