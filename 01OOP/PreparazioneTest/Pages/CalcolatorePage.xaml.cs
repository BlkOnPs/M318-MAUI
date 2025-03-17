using Microsoft.Maui.Graphics.Text;
using PreparazioneTest.Models;
namespace PreparazioneTest;

public partial class CalcolatorePage : ContentPage
{
    Calcolatore cal;
    public CalcolatorePage ( )
    {
        InitializeComponent ();
        cal = new Calcolatore ();
    }

    private void Button_Clicked ( object sender, EventArgs e )
    {
        string input = entDB.Text.Trim ();

        if (string.IsNullOrEmpty (input))
        {
            MostraMessaggio ("Inserire solo numeri positivi validi.");
            return;
        }

        try
        {
            double decibel = Convert.ToDouble (entDB.Text);
            cal.Decibel = decibel;
            entSoglia.Text = cal.CalcolaSoglia ();
            boxQudrato.Color = Color.FromArgb (cal.ColoreSoglia);
        }
        catch (FormatException) // Se l'input non è un numero
        {
            MostraMessaggio ("Inserire solo numeri validi.");
        }
        catch (ArgumentOutOfRangeException) // Se il numero è negativo
        {
            MostraMessaggio ("Inserire solo valori positivi.");
        }
    }

    private async void MostraMessaggio ( string mes )
    {
        await DisplayAlert ("Errore", mes, "OK");
    }
}
