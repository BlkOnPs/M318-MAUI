using _01ProgrammaOOP.Models;

namespace _01ProgrammaOOP
{
    public partial class MainPage : ContentPage
    {
        Rettangolo rettangolo;
        public MainPage()
        {
            InitializeComponent();
            rettangolo = new Rettangolo();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                rettangolo.LatoMaggiore = Convert.ToDouble(entLatoMaggiore.Text);
                rettangolo.LatoMinore = Convert.ToDouble(entLatoMinore.Text);
                entArea.Text = rettangolo.CalcolaArea().ToString();
                entPerimetro.Text = rettangolo.CalcolaPerimentro().ToString();
            }
            catch (ArgumentException ae)
            {
                MostraAlert(ae.Message);
            }
            
        }
        private async void MostraAlert(string mes)
        {
            await DisplayAlert("Errore", mes, "OK");
        }
    }
}
