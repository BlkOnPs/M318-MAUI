using PizzaApp.Models;
namespace PizzaApp
{
    public partial class MainPage : ContentPage
    {
        List<Pizza> pizze = new List<Pizza>();
        Pizza pizza = new Pizza("Pizza Vegetariana",13f,"image4.jpg","Pomodoro - Spinaci");
        Pizza pizza2 = new Pizza("Pizza senza Pomodoro", 9.50f, "image3.jpg", "Mozarella - Spinaci");
        Pizza pizza3 = new Pizza("Pizza Tonno e Cipolla", 14f, "image2.jpg", "Tonno - Cipolla");
        Pizza pizza4 = new Pizza("Pizza Margherita", 11f, "image1.jpg", "Pomodoro - Mozarella");
        public MainPage()
        {
            InitializeComponent();
            pizze.Add(pizza);
            pizze.Add(pizza2);
            pizze.Add(pizza3);
            pizze.Add(pizza4);
            pickPizza.ItemsSource = pizze;
        }

        private void pickPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza selectPizza = (Pizza)pickPizza.SelectedItem;
            imagePizza.Source = selectPizza.Image;
            labelPizza.Text = selectPizza.Nome;
            labelPrezzo.Text = selectPizza.Prezzo.ToString() + " Fr.-";
            labelIngredienti.Text = selectPizza.Ingredienti;
            horizontal.IsVisible = IsVisible;
            entValutazione.Text = selectPizza.Valuta.ToString();
            stepperValuta.Value = selectPizza.Valuta;

        }

        private void stepperValuta_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            entValutazione.Text = stepperValuta.Value.ToString();
            Pizza selectPizza = (Pizza)pickPizza.SelectedItem;
            selectPizza.Valuta = (int)stepperValuta.Value;
        }
    }

}
