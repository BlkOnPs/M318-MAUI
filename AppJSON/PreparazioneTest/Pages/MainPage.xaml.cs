using PreparazioneTest.Models;
using PreparazioneTest.Helpers;
using System.Text.Json;

namespace PreparazioneTest
{
    public partial class MainPage : ContentPage
    {
        Videogame selezionato;
        Archivio archivio;

        private readonly JsonSerializerOptions options = new ()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            IncludeFields = true
        };

        public MainPage ( )
        {
            InitializeComponent ();
            ReadJson ();
        }

        private void ReadJson ( )
        {
            if (File.Exists (PathHelper.GetConfigJsonPath ()))
            {
                string jsonString = File.ReadAllText (PathHelper.GetConfigJsonPath ());
                archivio = JsonSerializer.Deserialize<Archivio> (jsonString, options);
                PickVideogames.ItemsSource = archivio.Videogames;
            }
            else
            {
                string jsonString = "{\"Videogames\":[]}";
                File.WriteAllText(PathHelper.GetConfigJsonPath (), jsonString);
            }
        }

        private void PickVideogames_SelectedIndexChanged ( object sender, EventArgs e )
        {
            selezionato = (Videogame)PickVideogames.SelectedItem;
            EntTitolo.Text = selezionato.Title;
            EntSviluppatore.Text = selezionato.Name;
            EntDescrizione.Text = selezionato.Description;
            EntCommento.Text = selezionato.Commento;
            imgGalleria.Source = selezionato.Image;
        }

        private void EntCommento_TextChanged ( object sender, TextChangedEventArgs e )
        {
            selezionato = (Videogame)PickVideogames.SelectedItem;
            selezionato.Commento = EntCommento.Text;
        }
    }

}
