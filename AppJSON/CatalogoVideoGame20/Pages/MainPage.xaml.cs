using CatalogoVideoGame20.Helpers;
using CatalogoVideoGame20.Models;
using System.Text.Json;
using System.Xml.Schema;
namespace CatalogoVideoGame20
{
    public partial class MainPage : ContentPage
    {
        CatalogoVideogames catalogo;
        Videogame selezionato;

        private readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            IncludeFields = true
        };

        public MainPage()
        {
            InitializeComponent();
            ReadJson();
        }

        private void ReadJson ( )
        {
            if (File.Exists (PathHelper.GetConfigJsonPath ()))
            {
                string jsonString = File.ReadAllText (PathHelper.GetConfigJsonPath ());
                catalogo = JsonSerializer.Deserialize<CatalogoVideogames> (jsonString, options);
                PickVideogames.ItemsSource = catalogo.Videogames;
            }
            else
            {
                string jsonString = "{\"Videogames\":[]}";
                File.WriteAllText (PathHelper.GetConfigJsonPath (), jsonString);
            }
        }

        private void PickVideogames_SelectedIndexChanged(object sender, EventArgs e)
        {
            selezionato = (Videogame)PickVideogames.SelectedItem;
            entTitolo.Text = selezionato.Title;
            entSviluppatore.Text = selezionato.Name;
            entDescrizione.Text = selezionato.Description;
            entDescrizione.Text = selezionato.Commento;
        }
    }
}
