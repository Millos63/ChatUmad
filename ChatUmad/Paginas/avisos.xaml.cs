
using ChatUmad.Data;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading;

namespace ChatUmad;

public partial class avisos : ContentPage
{
    public List<Aviso1> Avisos { get; set; }
    public avisos()
    {
        InitializeComponent();
        Avisos = new List<Aviso1>
        {
            new Aviso1{Pro="Coordinador", Avisop="El dia 16 de Septiempre se realizará un simulacro a las 11:00am" },
            new Aviso1{Pro="Coordinador", Avisop="Hola a todos" }
        };
        this.BindingContext = this;
    }
    async void ShowToastButtonClicked(object? sender, EventArgs args)
    {
        var toast = Toast.Make("Se a publicado");
        await toast.Show();
    }

    private void OnCounterClicked1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Aver());
    }
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Aeditar());
    }
    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new archivo());
    }
}