namespace ChatUmad.Paginas;

public partial class EditUser : ContentPage
{
    private User user;

    public EditUser(User user)
	{
		InitializeComponent();

        // Almacenar el usuario pasado como parámetro
        this.user = user;

        // Poblar los campos de edición con los datos actuales del usuario
        NameEntry.Text = user.Name;
        EmailEntry.Text = user.Email;
        DegreeEntry.Text = user.Degree;
        RegistrationEntry.Text = user.Registration;
        RolePicker.SelectedItem = user.Role;
        StatePicker.SelectedItem = user.State;
    }


    private void OnClickSave(object sender, EventArgs e)
    {
        user.Name = NameEntry.Text;
        user.Email = EmailEntry.Text;
        user.Degree = DegreeEntry.Text;
        user.Registration = RegistrationEntry.Text;
        user.Role = RolePicker.SelectedItem as string;
        user.State = StatePicker.SelectedItem as string;

        Navigation.PopAsync();
    }
}