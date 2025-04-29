using Verifica2.Models;
namespace Verifica2;

public partial class CampiPage : ContentPage
{
    List<Campo> campi;
    Campo selezionato;

    //RESPONSABILI
    Responsabile marco;
    Responsabile francesco;
    Responsabile amel;

    //CAMPI
    Campo lugano;
    Campo tenero;
    Campo locarno;
    Campo gottardo;

	public CampiPage()
	{
		InitializeComponent();
        campi = new List<Campo>();

        //RESPONSABILI
        marco = new Responsabile("Marco", "Rossi");
        francesco = new Responsabile("Francesco","Totti");
        amel = new Responsabile("Amel","Cehic");

        //CAMPI
        lugano = new Campo("MiniGolf Lugano", "Via Golf 1, Caslano", 6987, "Lugano", "09946129477", "www.minigolf-lugano.ch", marco, "lugano.jpg");
        tenero = new Campo("MiniGolf Tenero", "Via alle Brere", 6598,"Tenero","0994352112","www.minigolf-tenero.ch",amel,"tenero.jpg");
        locarno = new Campo("MiniGolf Locarno", "Via Francesco Ballerini 3", 6600, "Locarno", "077725386322", "www.minigolf-locarno.ch", amel, "locarno.jpg");
        gottardo = new Campo("MiniGolf Gottardo", "Via Santi Orione e Guanella 68", 6956, "Lopagno", "09936374221", "www.minigolf-gottardo.ch", francesco, "san_gottardo.jpg");

        PopolaLista();
    }

    private void pickCampi_SelectedIndexChanged(object sender, EventArgs e)
    {
        selezionato = (Campo) pickCampi.SelectedItem;

        imgGolf.Source = selezionato.PathImm;
        entNome.Text = selezionato.Nome;
        entIndirizzo.Text = selezionato.Indirizzo;
        entNAP.Text = Convert.ToString(selezionato.NAP);
        entLoc.Text = selezionato.Citta;
        entResp.Text = selezionato.Responsabile.ToString();
        entTel.Text = selezionato.Telefono;
        entLink.Text = selezionato.Link;
        checkPreferito.IsChecked = selezionato.Preferito;
        entCommento.Text = selezionato.Commento;

    }

    private void checkPreferito_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        selezionato = (Campo)pickCampi.SelectedItem;
        selezionato.Preferito = checkPreferito.IsChecked;
    }

    public void PopolaLista()
    {
        campi.Add(lugano);
        campi.Add(tenero);
        campi.Add(locarno);
        campi.Add(gottardo);

        pickCampi.ItemsSource = campi;
    }

    private void entCommento_TextChanged(object sender, TextChangedEventArgs e)
    {
        selezionato = (Campo)pickCampi.SelectedItem;
        selezionato.Commento = entCommento.Text;
    }
}