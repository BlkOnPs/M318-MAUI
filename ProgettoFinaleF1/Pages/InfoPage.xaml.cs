using ProgettoFinaleF1.Models;
using ProgettoFinaleF1.Helpers;
using System.Text.Json;

namespace ProgettoFinaleF1;

public partial class InfoPage : ContentPage
{
	Driver selected;
    DriverList grid;

    private readonly JsonSerializerOptions options = new ()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        IncludeFields = true
    };

    public InfoPage()
	{
		InitializeComponent ();
		ReadJson ();
	}

	private void ReadJson ( )
	{
        if (File.Exists (PathHelper.GetConfigJsonPath ()))
        {
            string jsonString = File.ReadAllText (PathHelper.GetConfigJsonPath ());
            grid = JsonSerializer.Deserialize<DriverList> (jsonString, options);
            PickDrivers.ItemsSource = grid.Drivers;
        }
        else
        {
            string jsonString = "{\"Drivers\":[]}";
            File.WriteAllText (PathHelper.GetConfigJsonPath (), jsonString);
        }
    }

    private void PickDrivers_SelectedIndexChanged ( object sender, EventArgs e )
    {
        selected = (Driver) PickDrivers.SelectedItem;

        EntNome.Text = selected.FirstName;
        EntCognome.Text = selected.LastName;
        EntDataNascita.Text = selected.BirthDate.ToString ();
        EntNazionalita.Text = selected.Nationality;
        EntTeam.Text = selected.Team;
        EntNumGareVinte.Text = selected.RacesWon.ToString ();
        EntCampione.Text = selected.Championships.ToString ();
        ImgDriver.Source = selected.DriverImage;
        ImgHelmet.Source = selected.HelmetImage;
        ImgNumber.Source = selected.NumberImage;
    }
}