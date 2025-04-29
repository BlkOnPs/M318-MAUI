using AppJSON.Helpers;
using AppJSON.Models;
using System.Globalization;
using System.Text.Json;
namespace AppJSON;

public partial class CatalogoPage : ContentPage
{
    List<Libro> libri = new List<Libro>();
    Libreria libreria;
    Libro itemSelected;


    private readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };

	public CatalogoPage()
	{
		InitializeComponent();
        ReadData();
	}

    private void ReadData()
    {
        if (File.Exists(PathHelper.GetConfigJsonPath()))
        {
            var jsonString = File.ReadAllText(PathHelper.GetConfigJsonPath());
            libreria = JsonSerializer.Deserialize<Libreria>(jsonString, options);
            pickLibri.ItemsSource = libreria.Libri;
        }
        else
        {
            string jsonString = "{\"Libri\": []}";
            File.WriteAllText(PathHelper.GetConfigJsonPath(),jsonString);
        }
    }

    private void pickLibri_SelectedIndexChanged(object sender, EventArgs e)
    {
        itemSelected = (Libro)pickLibri.SelectedItem;
        entAutore.Text = itemSelected.Autore;
        entPubb.Text = itemSelected.AnnoPubblicazione.ToString();
        entTitolo.Text = itemSelected.Titolo;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string jsonString = JsonSerializer.Serialize(libreria, options);
        File.WriteAllText(Path.Combine(PathHelper.GetConfigJsonPath()), jsonString);
    }

    private void entTitolo_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Titolo = entTitolo.Text;
    }

    private void entAutore_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.Autore = entAutore.Text;
    }

    private void entPubb_TextChanged(object sender, TextChangedEventArgs e)
    {
        itemSelected.AnnoPubblicazione = Convert.ToInt32(entPubb.Text);
    }
}