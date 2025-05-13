using PokeDex.Classes.Contests;
using PokeDex.Classes.Helper;
using System.Text.Json.Serialization;

namespace PokeDex.Classes.Berries.Helper
{
    public class BerryFlavor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("berries")]
        public List<FlavorBerryMap> Berries { get; set; }
        [JsonPropertyName("contest_type")]
        public ContestType ContestType { get; set; }
        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }

    }
}