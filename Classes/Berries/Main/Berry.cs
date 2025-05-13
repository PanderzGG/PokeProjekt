using PokeDex.Classes.Berries.Helper;
using PokeDex.Classes.Types.Main;

using System.Text.Json.Serialization;

namespace PokeDex.Classes.Berries.Main
{
    public class Berry
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("growth_time")]
        public int GrowthTime { get; set; }
        [JsonPropertyName("max_harvest")]
        public int MaxHarvest { get; set; }
        [JsonPropertyName("natural_gift_power")]
        public int NaturalGiftPower { get; set; }
        [JsonPropertyName("size")]
        public int Size { get; set; }
        [JsonPropertyName("smoothness")]
        public int Smoothness { get; set; }
        [JsonPropertyName("soil_dryness")]
        public int SoilDryness { get; set; }
        [JsonPropertyName("firmness")]
        public BerryFirmness Firmness { get; set; }
        [JsonPropertyName("flavors")]
        public List<BerryFlavorMap> FlavorMaps { get; set; }
        [JsonPropertyName("item")]
        public PokeDex.Classes.Items.Main.Item Item { get; set; }
        [JsonPropertyName("natural_gift_type")]
        public PokemonType NaturalGiftType { get; set; }
    }
}