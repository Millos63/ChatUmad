using ChatUmad.Data;
namespace ChatUmad;

public partial class ver_avisos : ContentPage
{
    public List<Aviso1> Avisos { get; set; }
    public ver_avisos()
    {
        InitializeComponent();
        Avisos = new List<Aviso1>
        {
            new Aviso1{Pro="Coordinador", Avisop="El dia 16 de Septiempre se realizar� un simulacro a las 11:00am" }
        };
        this.BindingContext = this;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Aver());
    }
}