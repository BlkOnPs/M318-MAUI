using _09Geometria.Models;
namespace _09Geometria;

public partial class SferaPage : ContentPage
{
	Sfera sfera;
	public SferaPage()
	{
		InitializeComponent();
		sfera = new Sfera();
	}

    private void Button_Clicked ( object sender, EventArgs e )
    {
        try
        {
            sfera.Raggio = Convert.ToDouble (entRaggio.Text);
            entVolume.Text = Math.Round (sfera.CalcolaVolume (), 2).ToString ();
        }
        catch (ArgumentException ae)
        {
            MostraAlert (ae.Message);
        }
    }

    private async void MostraAlert ( string mes )
    {
        await DisplayAlert ("Errore", mes, "OK");
    }
}