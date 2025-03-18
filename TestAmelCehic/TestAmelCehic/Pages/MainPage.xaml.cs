namespace TestAmelCehic
{
    public partial class MainPage : ContentPage
    {
        string[] array = { "image1.png", "image2.png", "image3.png", "image4.png", "image5.png" };
        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
            CambiaImmagine();
        }
        

        public void CambiaImmagine()
        {
            int indice = random.Next(array.Length); 
            imageCasual.Source = array[indice];
        }

    }

}
