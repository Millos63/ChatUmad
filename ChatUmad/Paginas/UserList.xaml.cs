namespace ChatUmad.Paginas;

public partial class UserList : ContentPage
{
	public UserList()
	{
		InitializeComponent();

        // Ejemplos de usuarios ficticios
        var user = new List<User>
            {
                new User { Name = "Juan Pérez", Email = "juan@example.com", Degree = "Ing. Software", Registration = "20002020", Role = "Alumno", State = "Activo", UserImage = "night_owl.png" },
                new User { Name = "Ana López", Email = "ana@example.com", Degree = "Ing. Software", Registration = "20002020", Role = "Coordinador", State = "Activo", UserImage = "night_owl.png" },
                new User { Name = "Carlos Rodríguez", Email = "carlos@example.com", Degree = "Ing. Software", Registration = "20002020", Role = "Profesor", State = "Activo", UserImage = "night_owl.png" },
            };

        UsersListView.ItemsSource = user;
    }

    private async void OnClickedEdit(object sender, EventArgs e)
    {
        // Obtener el usuario correspondiente al botón presionado
        var user = (User)((Button)sender).CommandParameter;

        // Realizar la navegación a la página de edición de usuarios y pasar el usuario
        await Navigation.PushAsync(new EditUser(user));
    }

    // Controlador de eventos para el botón "Agregar Nuevo Usuario"
    private async void OnClickedAdd(object sender, EventArgs e)
    {
        // Navegar a la página de selección de rol
        await Navigation.PushAsync(new AddUser());
    }
}

public class User
{
    public string Name { get; internal set; }
    public string Email { get; internal set; }
    public string Degree { get; internal set; }
    public string Registration { get; internal set; }
    public string Role { get; internal set; }
    public string State { get; internal set; }
    public string UserImage { get;  set; }
}
