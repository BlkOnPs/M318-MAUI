using AppGames.Models;
namespace AppGames;

public partial class CatalogoPage : ContentPage
{
	List<Developer> developers = new List<Developer>();
	List<Videogame> videogames = new List<Videogame>();
    Videogame selectGame;

    public CatalogoPage()
	{
		InitializeComponent();
		developers.Add(new Developer("Maxis", "Stati Uniti"));
        developers.Add(new Developer("Microsoft", "Stati Uniti"));
        developers.Add(new Developer("Bethesda", "Stati Uniti"));

        videogames.Add(new Videogame("SimCity", developers[0],"City Builder","image2.jpg"));
        videogames.Add(new Videogame("Minecraft", developers[1], "Open World", "image1.jpg"));
        videogames.Add(new Videogame("Obvlion", developers[2], "Open World", "image3.jpg"));
        pickGames.ItemsSource = videogames;
    }

    private void pickGames_SelectedIndexChanged(object sender, EventArgs e)
    {
        frameGame.IsVisible = true;
        selectGame = (Videogame)pickGames.SelectedItem;

        entTitle.Text = selectGame.Title;
        entSvil.Text = selectGame.Developer.Name;
        editDesc.Text = selectGame.Description;
        imgGame.Source = selectGame.Image;
        editComment.Text = selectGame.Comment;
    }

    private void editComment_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            selectGame.Comment = editComment.Text;
        }
        catch (NullReferenceException nre)
        {
            DisplayAlert("Avviso", "errore", "OK");
        }        
    }
}