using System.Diagnostics.Tracing;

namespace _05Equation
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcolaFunzione ( object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EntA.Text) || string.IsNullOrWhiteSpace(EntB.Text) || string.IsNullOrWhiteSpace(EntC.Text))
                {
                    MostraMessaggio("Inserisci tutti i valori in tutti i campi...");
                    return;
                }

                int aNum = Convert.ToInt32 (EntA.Text);
                int bNum = Convert.ToInt32 (EntB.Text);
                int cNum = Convert.ToInt32 (EntC.Text);

                String ElevatoDue = "";
                String x = "";
                if (bNum < 0)
                {
                    ElevatoDue = "x² ";
                }
                else
                {
                    ElevatoDue = "x² + ";
                }

                if (cNum < 0)
                {
                    x = "x ";
                }
                else
                {
                    x = "x + ";
                }

                String equazione = aNum + ElevatoDue + bNum + x + cNum;
                EntEquazione.Text = equazione;
                DeterminaDirezioneParabola (aNum);
                CalcoloVerticiDeltaPunti (aNum, bNum, cNum);
            }
            catch(FormatException fe)
            {
                MostraMessaggio ("Valore non valido, inserire quello appropriato!");
            }
        }

        private void DeterminaDirezioneParabola( int aNum )
        {
            if( aNum > 0 )
            {
                EntDirezione.Text = "U - Sorride";
            }else if( aNum < 0)
            {
                EntDirezione.Text = "∩ - Piange";
            }
            else
            {
                EntDirezione.Text = "\"----\" - Orrizontale";
            }
        }

        private void CalcoloVerticiDeltaPunti( int aNum, int bNum, int cNum )
        {
            double calcoloX = -(double)bNum / (2 * aNum);
            double delta = Math.Pow (bNum, 2) - 4 * aNum * cNum;
            double calcoloY = -delta / (4 * aNum);

            String testo = "";

            calcoloX = Math.Round (calcoloX, 2);
            calcoloY = Math.Round(calcoloY, 2);

            EntXVertice.Text = calcoloX.ToString ();
            EntYVertice.Text = calcoloY.ToString ();
            EntDelta.Text = "Risultato: " + delta.ToString ();

            if (delta >= 2)
            {
                testo = "Passa per 2 punti";
                CalcolaPuntiIntersezione(aNum, bNum, cNum, delta);
            }
            else if (delta == 1)
            {
                testo = "Passa per un solo punto";
            }
            else if (delta <= 0)
            {
                testo = "Non passa per nessun punto";
                EntPunti.Text = "Nessuna Intersezione con asse X";
            }

            EntNPunti.Text = testo;
        }

        private void CalcolaPuntiIntersezione ( int aNum, int bNum, int cNum, double delta )
        {
            if (delta > 0)
            {
                double X1 = (-bNum + Math.Sqrt (delta)) / (2 * aNum);
                double X2 = (-bNum - Math.Sqrt (delta)) / (2 * aNum);

                X1 = Math.Round (X1, 2);
                X2 = Math.Round (X2, 2);

                EntPunti.Text = $"({X1}, 0) e ({X2}, 0)";
            }
            else if (delta == 0)
            {
                double x = -bNum / (2.0 * aNum);
                x = Math.Round (x, 2);

                EntPunti.Text = $"({x}, 0) - Vertice X";
            }
        }

        private async void MostraMessaggio(String messaggio )
        {
            await DisplayAlert ("Errore", messaggio, "Riprova");
        }
    }

}
