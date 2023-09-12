using System.Data;

namespace ChatUmad.Paginas;

public partial class SelectRole : ContentPage
{
	public SelectRole()
	{
		InitializeComponent();
	}

    private async void OnClickedConfirm(object sender, EventArgs e)
    {
        // Obtener el rol seleccionado
        string selectedRole = (string)RolePicker.SelectedItem;

        // Crear un nuevo usuario con el rol seleccionado (puedes configurar otras propiedades seg�n sea necesario)
        User newUser = new User
        {
            Role = selectedRole
        };

        // Navegar a la p�gina de edici�n de usuarios y pasar el nuevo usuario
        await Navigation.PushAsync(new EditUser(newUser));
    }
}