using TestAmelCehic.Models;
namespace TestAmelCehic;

public partial class ConvertitorePage : ContentPage
{
	AppConvertitore convertitore;
	public ConvertitorePage()
	{
		InitializeComponent();
		convertitore = new AppConvertitore(0, 0);
	}

    private void Converti(object sender, EventArgs e)
    {
		try
		{
            float franco = float.Parse(entFranco.Text);
            float cambioMedio = float.Parse(entCambioMedio.Text);
            convertitore.Franco = franco;
            convertitore.Cambio = cambioMedio;

            entEuro.Text = convertitore.ConvertiFrEu();
            labelDate.Text = convertitore.GeneraData();
        }
        catch (FormatException)
        {
            MostraMessaggio("Inserire solo numeri validi.");
        }
        catch (ArgumentException)
        {
            MostraMessaggio("Inserire solo valori positivi.");
        }
    }

    private async void MostraMessaggio(string mes)
    {
        await DisplayAlert("Errore", mes, "OK");
    }

}