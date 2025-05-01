using ProvaJson.Helpers;
using ProvaJson.Models;
using System.Text.Json;

namespace ProvaJson;

public partial class AggiungiVideogamePage : ContentPage
{
    Archivio archivio = new Archivio ();
    private readonly JsonSerializerOptions options = new ()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };

    public AggiungiVideogamePage ( )
    {
        InitializeComponent ();
        ReadData ();
    }

    private void ReadData ( )
    {
        if (File.Exists (PathHelper.GetConfigJsonPath ()))
        {
            var jsonString = File.ReadAllText (PathHelper.GetConfigJsonPath ());
            archivio = JsonSerializer.Deserialize<Archivio> (jsonString, options);
        }
        else
        {
            string jsonString = "{\"Videogames\": []}";
            File.WriteAllText (PathHelper.GetConfigJsonPath (), jsonString);
        }
    }

    private void btnAggiungi_Clicked ( object sender, EventArgs e )
    {
        try
        {
            Videogame nuovoVideogioco = new Videogame (entTitolo.Text,new Developer(entSviluppatore.Text),entDescrizione.Text,entPath.Text);

            archivio.AggiungiVideogioco (nuovoVideogioco);
            string jsonString = JsonSerializer.Serialize (archivio, options);
            File.WriteAllText (PathHelper.GetConfigJsonPath (), jsonString);
            AlertMessage ("Videogioco aggiunto");
        }
        catch (Exception ex)
        {
            AlertMessage (ex.Message);
        }

        CleanControls ();
    }

    private void CleanControls ( )
    {
        entTitolo.Text = string.Empty;
        entDescrizione.Text = string.Empty;
        entSviluppatore.Text = string.Empty;
        entPath.Text = string.Empty;
    }

    private async Task AlertMessage ( string message )
    {
        await DisplayAlert ("Alert", message, "OK");
    }
}