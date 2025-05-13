﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes.Pokemons.Helper
{
    public class PokemonFormSprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }
    }
}
