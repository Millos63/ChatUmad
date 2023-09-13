using ChatUmad.Data;
namespace ChatUmad;

public partial class Aver : ContentPage
{
    public List<Aviso1> Avisos { get; set; }
    public Aver()
    {
        InitializeComponent();
        Avisos = new List<Aviso1>
        {
            new Aviso1{Pro="Coordinador", Avisop="El dia 16 de Septiempre se realizará un simulacro a las 11:00am" }
        };
        this.BindingContext = this;
    }
}