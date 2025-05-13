using PokeDex.Classes.Pokemons.Main;
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

namespace PokeDex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly HttpClient _client = new HttpClient();
        static Pokemon? _Pokemon = new Pokemon();
        public MainWindow()
        {
            InitializeComponent();
            CheckConnection();
        }

        private async void CheckConnection()
        {
            try
            {
                string url = "https://www.google.de";
                var response = await _client.GetAsync(url);

                if (response.StatusCode.ToString() == "OK")
                {
                    MessageBox.Show("Connection is OK");
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
            string? picUrl;
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokeName}";
            string? response = null;

            PokePicture.Source = null;

            while(response == null)
            {
                TextPokemonNumberValue.Text = "Loading...";
                TextPokemonNameValue.Text = "Loading...";
                TextPokemonHeightValue.Text = "Loading...";
                TextPokemonWeightValue.Text = "Loading...";

                try
                {
                    response = await _client.GetStringAsync(url);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Can't resolve a response" + ex);
                    return;
                }
            }
            
            try
            {
                _Pokemon = JsonSerializer.Deserialize<Pokemon>(response);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Can't resolve a response {ex.ToString()}");
            }

            TextPokemonNumberValue.Text = _Pokemon.Id.ToString();
            TextPokemonNameValue.Text = _Pokemon.Name.ToString();
            TextPokemonHeightValue.Text = _Pokemon.Height.ToString();
            TextPokemonWeightValue.Text = _Pokemon.Weight.ToString();

            foreach(var move in _Pokemon.Moves)
            {
                ListBoxAbilities.Items.Add(move.Move.Name);
            }
        }
    }
}