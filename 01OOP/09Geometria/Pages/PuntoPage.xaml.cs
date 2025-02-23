using _09Geometria.Models;
namespace _09Geometria;

public partial class PuntoPage : ContentPage
{
	Punto punto;
	public PuntoPage()
	{
		InitializeComponent();
		punto = new Punto();
	}

    private void Button_Clicked ( object sender, EventArgs e )
    {
        try
        {
            punto.ValoreX = Convert.ToDouble (entX.Text);
            punto.ValoreY = Convert.ToDouble (entY.Text);
            entDistanza.Text = Math.Round (punto.CalcolaDistanza (), 2).ToString ();
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