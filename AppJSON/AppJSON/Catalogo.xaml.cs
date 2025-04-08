using AppJSON.Models;
using System.Text.Json;
namespace AppJSON
{
    public partial class MainPage : ContentPage
    {

        Score score = new Score();
        Score score1;
        string folderPath = @"C:/Datiallievo/";
        public MainPage()
        {
            InitializeComponent();
        }

        private void btSalva_Clicked(object sender, EventArgs e)
        {
            score.Nome = entNome.Text;
            score.Punteggio= Convert.ToInt32(entPunteggio.Text);

            try
            {
                string jsonString = JsonSerializer.Serialize(score);
                File.WriteAllText(Path.Combine(folderPath, "Score.json"), jsonString);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MostraErrore(dnfe.Message);
            }
        }
        private async void MostraErrore (string messaggio)
        {
            await DisplayAlert("Alert",messaggio,"OK");
        }

        private void btLeggi_Clicked(object sender, EventArgs e)
        {
            //string json = File.ReadAllText(Path.Combine(folderPath, "Score.json"));
            //score1 = JsonSerializer.Deserialize(json);

        }
    }

}
