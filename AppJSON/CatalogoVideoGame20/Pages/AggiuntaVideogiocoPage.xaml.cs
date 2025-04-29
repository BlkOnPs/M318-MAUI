using CatalogoVideoGame20.Helpers;
using CatalogoVideoGame20.Models;
using System.Text.Json;

namespace CatalogoVideoGame20;

public partial class AggiuntaVideogiocoPage : ContentPage
{
    CatalogoVideogames Videogames = new();

    private readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };

    public AggiuntaVideogiocoPage()
	{
		InitializeComponent();
		ReadJson();
	}

    private void ReadJson()
    {
        if (File.Exists(PathHelper.GetConfigJsonPath()))
        {
            string jsonString = File.ReadAllText(PathHelper.GetConfigJsonPath());
            Videogames = JsonSerializer.Deserialize<Videogame>(jsonString, options);

        }
        else
        {
            string jsonString = "{\"Videogames\": []}";
            File.WriteAllText(PathHelper.GetConfigJsonPath(), jsonString);
        }

    }

    private void btnAggiungi_Clicked(object sender, EventArgs e)
    {
        try
        {
            Videogames.AggiungiVideogame(new Videogame(entTitolo.Text,entSviluppatore.Text,entDescrizione.Text);
            string jsonString = JsonSerializer.Serialize(Videogames, options);
            File.WriteAllText(Path.Combine(PathHelper.GetConfigJsonPath()), jsonString);
            alert("Libro Aggiunto");
        }
        catch (Exception ex) { alert(ex.Message); }
        CleanControl();
    }

    private void CleanControl()
    {
        entTitolo.Text = string.Empty;
        entSviluppatore.Text = string.Empty;
        entDescrizione.Text = string.Empty;
        entImage.Text = string.Empty;

    }

    private async void alert(string messaggio)
    {
        await DisplayAlert("Alert", messaggio, "OK");
    }
}