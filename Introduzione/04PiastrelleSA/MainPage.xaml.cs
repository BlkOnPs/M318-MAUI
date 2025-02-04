namespace _04PiastrelleSA
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CalcolaPiastrelle(object sender, EventArgs e)
        {
            try{
                float lunghezzaPav = float.Parse(EntLungPav.Text);
                float larghezzaPav = float.Parse(EntLargPav.Text);

                float lunghezzaPia = float.Parse(EntLungPiasrt.Text);
                float larghezzaPia = float.Parse(EntLargPiastr.Text);

                if(lunghezzaPav < 0 || larghezzaPav < 0 || lunghezzaPia < 0 || larghezzaPia < 0)
                {
                    MostraMessaggioErrore("I valori non possono essere minori di 0!");
                }

                float areaPav = lunghezzaPav * larghezzaPav;
                float areaPias = lunghezzaPia * larghezzaPia;
                float quantitaPia = (areaPav / areaPias) * 1.1f;

                EntRisultato.Text = quantitaPia.ToString();
            }
            catch (FormatException fe)
            {
                MostraMessaggioErrore("Sembra che tu non stia inserendo un valore valido per questo tipo di dato da inserire, riprova!");
            }
        }
        private async void MostraMessaggioErrore(string message)
        {
            await DisplayAlert("Errore", message, "OK","Cancel");
        }
    }
}
