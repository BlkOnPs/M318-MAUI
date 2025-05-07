using PreparazioneTest.Helpers;
using PreparazioneTest.Models;
using System.Text.Json;

namespace PreparazioneTest;

public partial class AggiungiVideogamePage : ContentPage
{
    Archivio archivio;

    private readonly JsonSerializerOptions options = new ()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };

    public AggiungiVideogamePage()
	{
		InitializeComponent();
        ReadJson ();
	}

    private void ReadJson ( )
    {
        if (File.Exists (PathHelper.GetConfigJsonPath ()))
        {
            string jsonString = File.ReadAllText (PathHelper.GetConfigJsonPath ());
            archivio = JsonSerializer.Deserialize<Archivio> (jsonString, options);
        }
        else
        {
            string jsonString = "{\"Videogames\":[]}";
            File.WriteAllText (PathHelper.GetConfigJsonPath (), jsonString);
        }
    }

    private void BtnAggiungi_Clicked ( object sender, EventArgs e )
    {
        try
        {
            archivio.AggiungiVideogame (new Videogame (EntTitolo.Text, EntSviluppatore.Text,EntDescrizione.Text,EntImage.Text));
            string jsonString = JsonSerializer.Serialize (archivio, options);
            File.WriteAllText(Path.Combine(PathHelper.GetConfigJsonPath()),jsonString);
            alert ("Videogioco aggiunto");
        }
        catch (Exception ex){ alert (ex.Message); }
        CleanControl();
    }

    private void CleanControl ( )
    {
        EntTitolo.Text = string.Empty;
        EntSviluppatore.Text = string.Empty;
        EntDescrizione.Text = string.Empty;
        EntImage.Text = string.Empty;
    }

    private async void alert (string messaggio)
    {
        await DisplayAlert ("Attenzione", messaggio, "OK");
    }
}