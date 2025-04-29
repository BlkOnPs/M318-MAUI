using _15Pokemon.Models;
namespace _15Pokemon
{
    public partial class MainPage : ContentPage
    {
        List<Pokemon> pokemons = new List<Pokemon>();
        Pokemon pikachu;
        Pokemon charmender;
        Pokemon elementSelected; //Contiene l'elemento selezionato con il Picker
        public MainPage()
        {
            InitializeComponent();

            try
            {
                pikachu =  new Pokemon("Pikachu", 0.4f, 6, "Elettro", "pikachu.png", "Quando si arrabbia, libera subito l’energia accumulata nelle sacche sulle guance.", "Topo");
                charmender = new Pokemon("Charmender", 0.6f, 8, "Fuoco", "pikachu.png", "La fiamma che ha sulla coda indica lo stato della sua forza vitale: quando è fiacco, la fiamma è fioca.", "Lucertola");
                PopulateAbility();
                PopulateList();
            }
            catch (ArgumentOutOfRangeException ae) //Sollevva l'eccezzione personalizzata nel costruttore
            {
                ediDesc.Text = ae.Message; //Stampa messaggio di errore nell'Editor Descrizione
            }

            
        }

        private void pickPokemon_SelectedIndexChanged ( object sender, EventArgs e)
        {
            elementSelected = (Pokemon)pickPokemon.SelectedItem; //Contiene il riferimento all'oggetto Pokemon selezionato nell'item

            imagePath.Source = elementSelected.ImagePath;
            entName.Text = elementSelected.Name;
            entCat.Text = elementSelected.Category;
            entWeight.Text = elementSelected.Weight.ToString();
            entType.Text = elementSelected.Type;
            ediDesc.Text = elementSelected.Description;
            entHp.Text = elementSelected.Points.ToString();
            editAbility.Text = ""; //Scuota l'edit per poter scrivere le abilità del Pokemon(evitando che vengano accodate con il precedente)
            PrintAbility();

           
        }

        private void BtAllena_Clicked(object sender, EventArgs e)
        {
            elementSelected.Points++; //Aggiorna il punteggio di 1
            entHp.Text = elementSelected.Points.ToString();
        }


        private void PopulateAbility()
        {
            pikachu.AddAbility(new Ability("ElettroTela", "palla di ragnatela elettrificata"));
            pikachu.AddAbility(new Ability("Saetta", "fulmine"));
        }
        
        private void PopulateList()
        {
            pokemons.Add(pikachu);
            pokemons.Add(charmender);
            pickPokemon.ItemsSource = pokemons;
          
            
        }

        private void PrintAbility()
        {
            foreach (Ability a in elementSelected.Abilities)
            {
                editAbility.Text += a.Type + ": " + a.Description + "\n";
            }
        }
    }

}
