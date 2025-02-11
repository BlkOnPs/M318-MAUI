namespace _08GeneratorePassword;

public partial class GeneratorePassword : ContentPage
{
	String passwordGenerata;
    String caratteri = ".*[0123456789-!@#$%^&*()_+=\\[\\]{}|;:'\",.<>?/\\\\`~]¦§¬QWERTZUIOPASDFGHJKLYXCVBNMqwertzuiopasdfghjklyxcvbnm";
	Random random = new Random();
    public GeneratorePassword()
	{
		InitializeComponent();
	}

	

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            int lunghezza = Convert.ToInt32(EntLunghezza.Text);
            if (lunghezza <= 0)
            {
                MostraMessaggio("Non penso che la lunghezza puo essere nulla o minore..");
                return;
            }

            for (int i = 0; i < lunghezza; i++)
            {
                int num = random.Next(1, caratteri.Length);
                String substring = caratteri.Substring(num, 1);
                passwordGenerata += substring;
            }
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