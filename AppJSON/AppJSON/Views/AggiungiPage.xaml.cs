using AppJSON.Helpers;
using AppJSON.Models;
using System.Text.Json;
namespace AppJSON;

public partial class AggiungiPage : ContentPage
{
	Libreria libreria = new Libreria();
    private readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };
	public AggiungiPage()
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
        }
        else
        {
            string jsonString = "{\"Libri\": []}";
            File.WriteAllText(PathHelper.GetConfigJsonPath(), jsonString);
        }
    }

    private void btSave_Clicked(object sender, EventArgs e)
    {
        try
        {
            libreria.AggiungiLIbro(new Libro(entTitolo.Text, entAutore.Text, Convert.ToInt32(entAutore.Text)));
            string jsonString = JsonSerializer.Serialize(libreria, options);
            File.WriteAllText(Path.Combine(PathHelper.GetConfigJsonPath()), jsonString);
            AlertMessagge("Libro aggiunto");
        }
        catch (Exception ex)
        {
            AlertMessagge(ex.Message);
        }
        CleanControl();
    }

    private void CleanControl()
    {
        entTitolo.Text = string.Empty;
        entAutore.Text = string.Empty;
        entAnnoPubblicazione.Text = string.Empty;

    }

    private async Task AlertMessagge(string m)
    {
        await DisplayAlert("Alert", m, "Ok");
    }
}