namespace _08GeneratorePassword;

public partial class Sicurezza : ContentPage
{
	public Sicurezza()
	{
		InitializeComponent();
	}

    private void OnClickedConvalidaPassword ( object sender, EventArgs e )
    {
        if (EntPassword.Text.Trim() == "")
        {
            LabelStato.Text = "Inserisci una password";
            return;
        }

        String nome = EntNome.Text.Trim();
		String data = EntData.Date.ToString ("yyyyMMdd");
        String password = EntPassword.Text;
        String stato = "";

        if (password.Length <= 8)
        {
            stato = "PESSIMA";
            LabelStato.TextColor = Colors.Red;
        }

        if (password.ToLower ().Contains (nome))
        {
            stato = "NON SICURA";
            LabelStato.TextColor = Colors.Orange;
        }

        if (password.Contains (data))
        {
            stato = "NON SICURA";
            LabelStato.TextColor = Colors.Orange;
        }

        if (password.Length >= 12 && !(password.ToLower ().Contains (nome)) && !(password.Contains (data)))
        {
            stato = "PERFETTA";
            LabelStato.TextColor = Colors.Green;
        }
        else
        {
            stato = "PESSIMA";
        }

        LabelStato.Text = stato.ToString();
    }
}