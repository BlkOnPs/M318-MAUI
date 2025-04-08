using AppJSON.Models;
using System.Text.Json;
namespace AppJSON;

public partial class CatalogoPage : ContentPage
{
    List<Libro> libri = new List<Libro>();
    Libreria libreria;
    Libro itemSelected;

    string folderPath = Path.Combine("C:\\DatiAllievo", "libreria.json");

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
        ReadJson();
	}

    private void ReadJson() { 
        string jsonString = File.ReadAllText(folderPath);
        libreria = JsonSerializer.Deserialize<Libreria>(jsonString, options);
        pickLibri.ItemsSource = libreria.Libri;
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
        File.WriteAllText(Path.Combine(folderPath), jsonString);
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