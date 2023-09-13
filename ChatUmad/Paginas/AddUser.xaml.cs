using Windows.System;

namespace ChatUmad.Paginas;

public partial class AddUser : ContentPage
{
	public AddUser()
	{
		InitializeComponent();
	}

    private void OnClickSave(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}