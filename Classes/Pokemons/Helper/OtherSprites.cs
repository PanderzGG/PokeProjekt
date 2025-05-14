using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class OtherSprites
    {
        public DreamWorld? DreamWorld { get; set; }

        public Home Home { get; set; }

        [JsonPropertyName("official-artwork")]
        public OfficialArtwork? OfficialArtwork { get; set; }

        public Showdown? Showdown { get; set; }

        public OtherSprites()
        {

        }
    }
}
