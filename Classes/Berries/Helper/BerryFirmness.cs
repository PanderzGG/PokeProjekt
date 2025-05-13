using PokeDex.Classes.Berries.Main;
using PokeDex.Classes.Helper;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Berries.Helper
{
    public class BerryFirmness
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("berries")]
        public List<Berry> Berries { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }
    }
}