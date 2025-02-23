using _09Geometria.Models;
namespace _09Geometria;

public partial class CuboPage : ContentPage
{
	Cubo cubo;
	public CuboPage()
	{
		InitializeComponent();
		cubo = new Cubo();
	}

    private void Button_Clicked ( object sender, EventArgs e )
    {
        try
        {
            cubo.Lato = Convert.ToDouble (entLato.Text);
            entVolume.Text = Math.Round (cubo.CalcolaVolume(), 2).ToString ();
            entPerimetro.Text = Math.Round (cubo.CalcolaPerimetro(), 2).ToString ();
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