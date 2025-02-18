using _09Geometria.Models;
namespace _09Geometria;

public partial class CerchioPage : ContentPage
{
	Cerchio cerchio = new Cerchio();
	public CerchioPage()
	{
		InitializeComponent();
		cerchio = new Cerchio();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			cerchio.Raggio = Convert.ToDouble(entRaggio.Text);
			entArea.Text = Math.Round(cerchio.CalcolaArea(),2).ToString();
			entCirconferenza.Text = Math.Round(cerchio.CalcolaCirconferenza(),2).ToString();
		}
		catch(ArgumentException ae)
		{
			MostraAlert(ae.Message);
		}
    }

    private async void MostraAlert(string mes)
    {
        await DisplayAlert("Errore", mes, "OK");
    }
}