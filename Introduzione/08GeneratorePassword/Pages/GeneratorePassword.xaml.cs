namespace _08GeneratorePassword;

public partial class GeneratorePassword : ContentPage
{
    String caratteri = ".*[0123456789-!@#$%^&*()_+=\\[\\]{}|;:'\",.<>?/\\\\`~]¦§¬QWERTZUIOPASDFGHJKLYXCVBNMqwertzuiopasdfghjklyxcvbnm";
	Random random = new Random();
    public GeneratorePassword()
	{
		InitializeComponent();
	}

	

    private void OnClickedGeneraPassword(object sender, EventArgs e)
    {
        try
        {
            int lunghezza = Convert.ToInt32(EntLunghezza.Text);
            if (lunghezza <= 0)
            {
                MostraMessaggio("Non penso che la lunghezza puo essere nulla o minore..");
                return;
            }
            String passwordGenerata = "";
            for (int i = 0; i < lunghezza; i++)
            {
                int num = random.Next(0, caratteri.Length);
                passwordGenerata += caratteri[num];
            }
            EntPassword.Text = passwordGenerata;
        }
        catch (FormatException fe)
        {
            MostraMessaggio("Inserisci un valore valido..");
        }
    }
    
    public async void MostraMessaggio(String messaggio)
	{
		await DisplayAlert("Errore", messaggio, "Riprova");
	}
}