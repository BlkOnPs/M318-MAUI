using _03AppHotel.Models;
namespace _03AppHotel
{
    public partial class MainPage : ContentPage
    {
        string[] immagini = { "image.jpg", "image2.jpg", "image3.jpg", "image4.jpg", "image5.jpg", "image6.jpg", "image7.jpg", "image8.jpg", "image9.jpg", "image10.jpg" };
        private int indice = 0;
        Stanza stanza = new Stanza(125,10,"Prova");
        Calcolatore calcolatore;
        public MainPage()
        {
            InitializeComponent();
            calcolatore = new Calcolatore(stanza);
            editOss.Text = calcolatore.Stanza.Osservazioni;
            entStanza.Text = calcolatore.Stanza.Numero.ToString();
            entCosto.Text = calcolatore.Stanza.Costo.ToString();
        }

        private void stepPersone_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            entPersone.Text = stepPersone.Value.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            calcolatore.Persone = Convert.ToInt32(stepPersone.Value);
            calcolatore.DataArrivo = dateArrivo;
            calcolatore.DataPartenza = datePartenza;
            calcolatore.HasAnimal = checkAnimali.IsChecked;

            MessaggioCalcolatore();
        }

        private void MessaggioCalcolatore()
        {
            double giorni = calcolatore.CalcolaGiorni();
            double costo = calcolatore.CalcolaCosto();
            string messagge = $"Il costo del soggiorno per {giorni} giorni è di {costo} Fr.-";
            DisplayAlert("Costo Pernottamento", messagge, "OK");
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            indice -= 1;
            if(indice == -1)
            {
                indice = 5;
            }
            imageStanza.Source = immagini[indice];
        }

        private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            indice += 1;
            if (indice == 6)
            {
                indice = 0;
            }
            imageStanza.Source = immagini[indice];
        }
    }

}
