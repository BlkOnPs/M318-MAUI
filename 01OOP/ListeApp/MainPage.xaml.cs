using ListeApp.Models;
namespace ListeApp
{
    public partial class MainPage : ContentPage
    {
        List<Frutto> frutti = new List<Frutto>();
        Frutto mela = new Frutto("Mela","Italia");
        Frutto pera = new Frutto("Pera", "Spagna");
        Frutto cocco = new Frutto("Cocco", "India");
        Frutto avocado = new Frutto("Avocado","Messico");
        public MainPage()
        {
            InitializeComponent();
            frutti.Add(mela);
            frutti.Add(pera);
            frutti.Add(cocco);
            frutti.Insert(3,avocado);

            pickFrutti.ItemsSource = frutti;

            entFrutto.Text = frutti[0].Nome;
            foreach (Frutto item in frutti)
            {
                editFrutti.Text += item + "\n";
            }
        }

        private void pickFrutti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Frutto selectFruit = (Frutto) pickFrutti.SelectedItem;
            entSeleziona.Text = selectFruit.ToString();
        }
    }

}
