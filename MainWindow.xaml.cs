using PokeDex.Classes.Moves.Main;
using PokeDex.Classes.Pokemons.Helper;
using PokeDex.Classes.Pokemons.Main;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace PokeDex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly HttpClient _client = new HttpClient();
        static Pokemon? _Pokemon = new Pokemon();
        static bool isMale = true;
        static bool isShiny = false;
        public MainWindow()
        {
            InitializeComponent();
            CheckConnection();
            PikaLoadHide();
            
        }

        private async void CheckConnection()
        {
            try
            {
                string url = "https://pokeapi.co/api/v2/pokemon/pikachu";
                var response = await _client.GetAsync(url);

                if (response.StatusCode.ToString() == "OK")
                {
                    //MessageBox.Show("Connection is OK");
                }
                else
                {
                    MessageBox.Show("Can't connect to the Internet");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't resolve a response" + ex);
            }
        }

        private async void Search_Pokemon_Click(object sender, RoutedEventArgs e)
        {
            string pokeName = PokeSearchbox.Text.ToString().ToLower();
            SearchPokemon(pokeName);
        }

        private async void ListBoxAbilities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedMove = "";

            if(ListBoxAbilities.SelectedItem != null)
            {
                selectedMove = ListBoxAbilities.SelectedItem.ToString();
            }
            
            string url = $"https://pokeapi.co/api/v2/move/{selectedMove}";
            string? response = null;
            PokemonMove? currentMoveSet = _Pokemon.Moves.FirstOrDefault(x => x.Move.Name == selectedMove);

            Move? currentMove = new Move();

            try
            {
                response = await _client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't resolve a response {ex.ToString()}");
                
            }

            if (!string.IsNullOrWhiteSpace(response))
            {
                try
                {
                    var options = new JsonSerializerOptions
                    {
                        MaxDepth = 96,
                        ReadCommentHandling = JsonCommentHandling.Skip,
                        AllowTrailingCommas = true
                    };
                    currentMove = JsonSerializer.Deserialize<Move>(response, options);
                    response = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Deserialisieren: {ex.Message}\nResponse:\n{response}");
                    Clipboard.SetText(ex.Message);
                    MessageBox.Show("Response wurde in die Zwischenablage kopiert.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Die API-Antwort ist leer.");
                return;
            }

            if (currentMove.Name != null)
            {
                TextMoveNameValue.Text = currentMove.Name.ToString();
                TextMovePPValue.Text = currentMove.PP.ToString();
                TextMovePowerValue.Text = currentMove.Power.ToString();
                TextMoveAccuracyValue.Text = currentMove.Accuracy.ToString();
            }
        }

        private void PikaLoadHide()
        {
            LoadingPika1.Visibility = Visibility.Hidden;
            LoadingPika2.Visibility = Visibility.Hidden;
            LoadingPika3.Visibility = Visibility.Hidden;
            LoadingPika4.Visibility = Visibility.Hidden;
        }

        private void PokeSearchbox_GotFocus(object sender, RoutedEventArgs e)
        {
            PokeSearchbox.Clear();
        }

        private void ButtonShiny_Click(object sender, RoutedEventArgs e)
        {
            isShiny = true;
            PictureLoading();
        }

        private void ButtonMaleSprite_Click(object sender, RoutedEventArgs e)
        {
            isMale = true;
            PictureLoading();

        }

        private void ButtonFemaleSprite_Click(object sender, RoutedEventArgs e)
        {
            isMale = false;
            PictureLoading();

        }        

        private void ButtonNormalSprite_Click(object sender, RoutedEventArgs e)
        {
            isShiny = false;
            PictureLoading();
        }

        private void PictureLoading()
        {
            switch (isShiny)
            {
                case true:
                    if (isMale)
                    {
                        string picUrl = _Pokemon.Sprites.FrontShiny;
                        PokePicture.Source = _Pokemon.getImage(picUrl);
                        //var maleShiny = new BitmapImage();
                        //maleShiny.BeginInit();
                        //maleShiny.UriSource = new Uri(_Pokemon.Sprites.FrontShiny);
                        //maleShiny.EndInit();
                        //PokePicture.Source = maleShiny;
                    }
                    else if (!isMale && _Pokemon.Sprites.FrontShinyFemale != null)
                    {
                        string picUrl = _Pokemon.Sprites.FrontShinyFemale;
                        PokePicture.Source = _Pokemon.getImage(picUrl);
                        //var femaleShiny = new BitmapImage();
                        //femaleShiny.BeginInit();
                        //femaleShiny.UriSource = new Uri(_Pokemon.Sprites.FrontShinyFemale);
                        //femaleShiny.EndInit();
                        //PokePicture.Source = femaleShiny;
                    }
                    else
                    {
                        MessageBox.Show("No Shiny Female variant.");
                        isMale = true;
                        PictureLoading();
                        return;
                    }
                    break;
                case false:
                    if (isMale)
                    {
                        string picUrl = _Pokemon.Sprites.FrontDefault;
                        PokePicture.Source = _Pokemon.getImage(picUrl);
                        //var maleNormal = new BitmapImage();
                        //maleNormal.BeginInit();
                        //maleNormal.UriSource = new Uri(_Pokemon.Sprites.FrontDefault);
                        //maleNormal.EndInit();
                        //PokePicture.Source = maleNormal;
                    }
                    else if (!isMale)
                    {
                        string picUrl = _Pokemon.Sprites.FrontFemale;
                        PokePicture.Source = _Pokemon.getImage(picUrl);
                        //var femaleNormal = new BitmapImage();
                        //femaleNormal.BeginInit();
                        //femaleNormal.UriSource = new Uri(_Pokemon.Sprites.FrontFemale);
                        //femaleNormal.EndInit();
                        //PokePicture.Source = femaleNormal;
                    }
                    else
                    {
                        MessageBox.Show("No Female variant.");
                        isMale = true;
                        PictureLoading();
                        return;
                    }
                    break;
            }
        }

        private void ButtonNextPokemon_Click(object sender, RoutedEventArgs e)
        {
            int? nextPokemon = _Pokemon.NextPokemon();
            if(nextPokemon != null)
            {
                SearchPokemon(nextPokemon.ToString());
            }
            else
            {
                MessageBox.Show("No next Pokemon.");
            }
        }

        private void ButtonPreviousPokemon_Click(object sender, RoutedEventArgs e)
        {
            int? previousPokemon = _Pokemon.PreviousPokemon();
            if (previousPokemon != null)
            {
                SearchPokemon(previousPokemon.ToString());
            }
            else
            {
                MessageBox.Show("No previous Pokemon.");
            }
        }

        private async void SearchPokemon(string pokeName)
        {
            string? picUrl;
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokeName}";
            string? response = null;

            var mewLoad = new BitmapImage();
            mewLoad.BeginInit();
            mewLoad.UriSource = new Uri("C:\\Users\\sasch\\source\\repos\\PokeDex\\PokeDex\\Media\\Loading\\mewload.gif");
            mewLoad.EndInit();
            ImageBehavior.SetAnimatedSource(PokePicture, mewLoad);

            LoadingPika1.Visibility = Visibility.Visible;
            LoadingPika2.Visibility = Visibility.Visible;
            LoadingPika3.Visibility = Visibility.Visible;
            LoadingPika4.Visibility = Visibility.Visible;

            while (response == null)
            {

                TextPokemonNumberValue.Text = "";
                TextPokemonNameValue.Text = "";
                TextPokemonHeightValue.Text = "";
                TextPokemonWeightValue.Text = "";

                try
                {
                    response = await _client.GetStringAsync(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{pokeName} does not exist.");
                    PikaLoadHide();
                    ImageBehavior.SetAnimatedSource(PokePicture, null);
                    ListBoxAbilities.Items.Clear();
                    TextMoveAccuracyValue.Text = "";
                    TextMoveNameValue.Text = "";
                    TextMovePowerValue.Text = "";
                    TextMovePPValue.Text = "";
                    return;
                }
            }

            try
            {
                _Pokemon = new Pokemon();
                _Pokemon = _Pokemon.DeserializeResponse(response);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't resolve a response {ex.ToString()}");
            }

            var sprite = new BitmapImage();
            sprite.BeginInit();
            if(_Pokemon.Sprites.FrontDefault != null)
            {
                sprite.UriSource = new Uri(_Pokemon.Sprites.Other.OfficialArtwork.FrontDefault);
            }
            else
            {
                sprite.UriSource = new Uri("https://pokeapi.co/api/v2/item/1/");
            }
            sprite.EndInit();
            ImageBehavior.SetAnimatedSource(PokePicture, sprite);

            TextPokemonNumberValue.Text = _Pokemon.Id.ToString();
            TextPokemonNameValue.Text = _Pokemon.PokeName();
            TextPokemonHeightValue.Text = _Pokemon.PokeHeight();
            TextPokemonWeightValue.Text = _Pokemon.PokeWeight();
            PikaLoadHide();

            ListBoxAbilities.Items.Clear();
            foreach (var move in _Pokemon.Moves)
            {
                ListBoxAbilities.Items.Add(move.Move.Name);
            }

            PokeSearchbox.Text = _Pokemon.Name.ToString();
            ListBoxAbilities.SelectedIndex = 0;
        }

        private void ButtonArtwork_Click(object sender, RoutedEventArgs e)
        {
            if (_Pokemon.Sprites.Other.OfficialArtwork.FrontDefault != null)
            {
                string picUrl = _Pokemon.Sprites.Other.OfficialArtwork.FrontDefault;
                PokePicture.Source = _Pokemon.getImage(picUrl);

            }
            else
            {
                MessageBox.Show("No official artwork available.");
                return;
            }

        }
    }
}