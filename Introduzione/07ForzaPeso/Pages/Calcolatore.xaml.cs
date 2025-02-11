namespace _07ForzaPeso;

public partial class Calcolatore : ContentPage
{
    double valoreInserito = 0;
    double forzaTerra = 9.81;
    double fozaLuna = 1.625;
    double forzaMarte = 3.76;
    double calcoloLuna;
    double calcoloMarte;
    double calcoloTerra;

    public Calcolatore()
	{
		InitializeComponent();
	}

    private void OnClickedCalcolaForzaPeso(object sender, EventArgs e)
    {
        try{
            valoreInserito = Convert.ToDouble(EntValore.Text);

            if (valoreInserito <= 0)
            {
                MostraMessaggio("Inserisci un valore appropriato...");
                return;
            }

            calcoloLuna = valoreInserito * fozaLuna;
            calcoloMarte = valoreInserito * forzaMarte;
            calcoloTerra = valoreInserito * forzaTerra;

            EntLuna.Text = Math.Round(calcoloLuna, 2).ToString() + "N";
            EntMarte.Text = Math.Round(calcoloMarte, 2).ToString() + "N";
            EntTerra.Text = Math.Round(calcoloTerra, 2).ToString() + "N";
        }
        catch (FormatException fe){
            MostraMessaggio("Valore non valido, riprovare con un altro valore!");
        }
    }

    private async void MostraMessaggio(string messaggio)
    {
        await DisplayAlert("Attenzione", messaggio, "Riprova");
    }
}