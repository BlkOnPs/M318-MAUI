using _09Geometria.Models;
namespace _09Geometria;

public partial class TriangoloPage : ContentPage
{
    Triangolo triangolo;
	public TriangoloPage()
	{
		InitializeComponent();
        triangolo = new Triangolo();
	}

    private void Button_Clicked ( object sender, EventArgs e )
    {
        try
        {
            triangolo.Base = Convert.ToDouble(entBase.Text);
            triangolo.Altezza = Convert.ToDouble (entAltezza.Text);
            entArea.Text = Math.Round(triangolo.CalcolaArea(),2).ToString();
            entPerimetro.Text = Math.Round (triangolo.CalcolaPerimentro (), 2).ToString ();
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