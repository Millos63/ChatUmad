namespace ChatUmad.Paginas;

public partial class AgregarMateria : ContentPage
{
	public AgregarMateria()
	{
		InitializeComponent();
	}

    private void OnClickSave(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}