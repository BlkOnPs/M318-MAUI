namespace _01Orario
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void CounterBtn_Clicked(object sender, EventArgs e)
        {
            orologio.Text = DateTime.Now.ToString();
        }
    }

}
