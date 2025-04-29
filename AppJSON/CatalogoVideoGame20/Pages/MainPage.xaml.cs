using CatalogoVideoGame20.Models;
using System.Xml.Schema;
namespace CatalogoVideoGame20
{

    

    
    public partial class MainPage : ContentPage
    {
        List<Videogame> videogames = new List<Videogame>();
        Videogame selezionato;

        Developer d1;
        Developer d2;

        Videogame v1;
        Videogame v2;
        public MainPage()
        {
            InitializeComponent();
            d1 = new Developer("Activision", "California");
            d2 = new Developer("Mojang", "Stockholm ");

            v1 = new Videogame("Minecraft",d1, "In Minecraft, players explore a procedurally generated, " +
                "three-dimensional world with virtually infinite terrain made up of voxels.","mine.jpg");
            v2 = new Videogame("Call Of Duty", d2, "Call of Duty is a first-person shooter video game based " +
                "on id Tech 3, and was released on October 29, 2003. ", "cod.jpg");

            RiempiLista();
        }

        public void RiempiLista()
        {
            videogames.Add(v1);
            videogames.Add(v2);

            PickVideogames.ItemsSource = videogames;
        }

        private void PickVideogames_SelectedIndexChanged(object sender, EventArgs e)
        {
            selezionato = (Videogame) PickVideogames.SelectedItem;

            entTitolo.Text = selezionato.Title;
            entSviluppatore.Text = selezionato.Developer.ToString();
            entDescrizione.Text = selezionato.Description;
            imageGalleria.Source = selezionato.Image;
        }
    }

}
