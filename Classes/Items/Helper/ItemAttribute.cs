using PokeDex.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Item.Helper
{
    public class ItemAttribute
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("items")]
        public List<PokeDex.Classes.Items.Main.Item> Items { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
        [JsonPropertyName("descriptions")]
        public List<Description> Descriptions { get; set; }
    }
}
