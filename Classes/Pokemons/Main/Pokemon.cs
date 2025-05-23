﻿using PokeDex.Classes.GenerationAndVersion;
using PokeDex.Classes.Item.Helper;
using PokeDex.Classes.Pokedexes.Helper;
using PokeDex.Classes.Pokemons.Helper;
using PokeDex.Classes.Types.Helper;
using PokeDex.Classes.Types.Main;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PokeDex.Classes.Pokemons.Main
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("order")]
        public int? Order { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("abilities")]
        public List<PokemonAbility>? PokemonAbilities { get; set; }

        [JsonPropertyName("forms")]
        public List<PokemonForm>? Forms { get; set; }

        [JsonPropertyName("game_indices")]
        public List<VersionGameIndex>? GameIndices { get; set; }

        [JsonPropertyName("held_items")]
        public List<PokemonHeldItem>? HeldItems { get; set; }

        [JsonPropertyName("location_area_encounters")]
        public string? LocationAreaEncounters { get; set; }

        [JsonPropertyName("moves")]
        public List<PokemonMove>? Moves { get; set; }

        [JsonPropertyName("past_types")]
        public List<PokemonTypePast>? PastTypes { get; set; }

        [JsonPropertyName("past_abilities")]

        public List<PokemonAbilityPast>? PastAbilities { get; set; }

        [JsonPropertyName("sprites")]
        public PokemonSprites? Sprites { get; set; }

        [JsonPropertyName("cries")]
        public PokemonCries? Cries { get; set; }

        [JsonPropertyName("species")]
        public PokemonSpecies? Species { get; set; }
        [JsonPropertyName("stats")]
        public List<PokemonStat>? Stats { get; set; }

        [JsonPropertyName("types")]
        public List<PokemonType> Types { get; set; }



        public Pokemon DeserializeResponse(string response)
        {
            Pokemon pokemon = new Pokemon();

            try
            {
                pokemon = JsonSerializer.Deserialize<Pokemon>(response, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true

                });
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error deserializing Pokemon: " + ex.Message);
                return null;
            }

            return pokemon;
        }

        public string PokeName()
        {
            string name = this.Name;
            string pokeName = char.ToUpper(name[0]) + name.Substring(1);
            return pokeName;
        }

        public string PokeWeight()
        {
            double weight = this.Weight / 10.0;
            string weightString = weight.ToString("N1", new CultureInfo("en-EN")) + " Meter";
            return weightString;
        }

        public string PokeHeight()
        {
            double height = this.Height / 10.0;
            string heightString = height.ToString("N1", new CultureInfo("en-EN")) + " Kilogram";
            return heightString;
        }

        public int PreviousPokemon()
        {
            int thisNumber = this.Id;
            int previousNumber = thisNumber - 1;
            if (previousNumber < 1)
            {
                previousNumber = 1;
            }
            return previousNumber;
        }

        public int NextPokemon()
        {
            int thisNumber = this.Id;
            int nextNumber = thisNumber + 1;
            if (nextNumber > 1025)
            {
                nextNumber = 1025;
            }
            return nextNumber;
        }

        public BitmapImage getImage(string picUrl)
        {
            BitmapImage pokePic = new BitmapImage();

            try
            {
                pokePic.BeginInit();
                pokePic.UriSource = new Uri(picUrl);
                pokePic.EndInit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Couldn't resolve Image");
            }

            return pokePic;
        }
    }
}
