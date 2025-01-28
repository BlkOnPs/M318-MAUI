namespace _00Introduzione
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            //Evento che permette di stampare nel label il contenuto del 
            InitializeComponent();
        }

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(entName.Text)) {
                lbName.Text = "Ciao a tutti";
            }
            else
            {
                lbName.Text = entName.Text;
            }
        }
    }

}
