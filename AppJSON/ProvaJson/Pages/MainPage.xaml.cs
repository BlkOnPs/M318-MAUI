using ProvaJson.Models;
namespace ProvaJson
{
    public partial class MainPage : ContentPage
    {
        Videogame selezionato;

        Developer d1;
        Developer d2;

        Videogame v1;
        Videogame v2;

        List<Videogame> videogames = new List<Videogame>();

        public MainPage ( )
        {
            InitializeComponent ();  

            d1 = new Developer ("Activision", "California");
            d2 = new Developer ("Mojang", "Stockholm ");

            v1 = new Videogame ("Call Of Duty",d1, "Call of Duty è una delle serie di sparatutto " +
                "in prima persona più iconiche e popolari del mondo videoludico. Nato come simulazione " +
                "di guerra ambientata nella Seconda Guerra Mondiale, il gioco si è evoluto nel tempo " +
                "abbracciando scenari moderni e futuristici, mantenendo sempre un ritmo frenetico e " +
                "un’azione adrenalinica. Con campagne cinematografiche, modalità multiplayer competitive " +
                "e battaglie online ricche di tensione e strategia, COD offre un'esperienza coinvolgente " +
                "dove riflessi pronti, lavoro di squadra e tattiche intelligenti sono fondamentali. " +
                "È il gioco ideale per chi cerca sfide intense, ambientazioni realistiche e una community " +
                "globale pronta a combattere in ogni angolo del mondo.", "cod.jpg");
            v2 = new Videogame ("Minecraft",d2, "Minecraft è un videogioco sandbox iconico e senza tempo " +
                "che ha conquistato milioni di giocatori in tutto il mondo grazie alla sua libertà creativa " +
                "e al suo stile unico a blocchi. In un mondo generato proceduralmente, i giocatori possono " +
                "esplorare, costruire, scavare, combattere e sopravvivere, dando vita a tutto ciò che immaginano, " +
                "dai rifugi più semplici alle città più complesse. Con modalità che spaziano dalla Sopravvivenza " +
                "alla Creativa, passando per l’Avventura e il multigiocatore online, Minecraft stimola la fantasia, " +
                "l’ingegno e la collaborazione. È molto più di un gioco: è uno spazio virtuale dove tutto è possibile, " +
                "limitato solo dalla tua immaginazione.","mine.jpg");

            RiempiLista ();
        }

        public void RiempiLista() 
        { 
            videogames.Add(v1);
            videogames.Add(v2);

            PickVideogames.ItemsSource = videogames;
        }

        private void PickVideogames_SelectedIndexChanged ( object sender, EventArgs e )
        {
            selezionato = (Videogame)PickVideogames.SelectedItem;
            entTitolo.Text = selezionato.Title;
            entSviluppatore.Text = selezionato.Developer.ToString();
            entDescrizione.Text = selezionato.Description;
            imgGalleria.Source = selezionato.Image;
            entCommento.Text = selezionato.Commento;
        }

        private void entCommento_TextChanged ( object sender, TextChangedEventArgs e )
        {
            selezionato = (Videogame)PickVideogames.SelectedItem;
            selezionato.Commento = entCommento.Text;
        }
    }

}
