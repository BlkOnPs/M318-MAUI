namespace ProgettoFinaleF1
{
    public partial class MainPage : ContentPage
    {
        private List<string> images = new ()
    {
        "f1_bg.jpg",
        "f1_bg2.jpg",
        "f1_bg3.jpg",
        "f1_bg4.jpg",
        "f1_bg5.jpg",
        "f1_bg6.jpg",
        "f1_bg7.jpg",
        "f1_bg8.jpg",
        "f1_bg9.jpg"
    };

        private int currentIndex = 0;
        public MainPage ( )
        {
            InitializeComponent ();
            CambiaSfondo ();
        }

        private void CambiaSfondo ( )
        {
            Device.StartTimer (TimeSpan.FromSeconds (5), ( ) =>
            {
                currentIndex = (currentIndex + 1) % images.Count;
                imgBackground.Source = images[currentIndex];
                return true;
            });
        }
    }
}
