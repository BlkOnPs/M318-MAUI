namespace _03RidimensionaBox
{
    public partial class MainPage : ContentPage
    {
        int min = 50;
        int max = 1200;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RidimensionaBox(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(input.Text);

                if (numero < min || numero > max)
                {
                    MostraMessaggio("Il quadrato puo essere solo maggiore di 50 o minore di 1200");
                }
                else
                {
                    box1.WidthRequest = numero;
                }
            }
            catch (FormatException ex)
            {
                MostraMessaggio("NO STRINGA");
            }
        }

        private async void MostraMessaggio(string Messaggio)
        {
            await DisplayAlert("Avviso", Messaggio, "OK");
        }

        private void button1_Clicked(object sender, EventArgs e)
        {

        }
    }

}
