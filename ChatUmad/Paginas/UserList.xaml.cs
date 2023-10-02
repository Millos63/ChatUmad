namespace ChatUmad.Paginas;

public partial class UserList : ContentPage
{
	public UserList()
	{
		InitializeComponent();

        // Ejemplos de usuarios ficticios
        var user = new List<User>
            {
                new User { Name = "Juan P�rez", Email = "juan@example.com", Degree = "Ing. Software", Registration = "20002020", Role = "Alumno", State = "Activo", UserImage = "night_owl.png" },
                new User { Name = "Ana L�pez", Email = "ana@example.com", Degree = "Ing. Software", Registration = "20002020", Role = "Coordinador", State = "Activo", UserImage = "night_owl.png" },
                new User { Name = "Carlos Rodr�guez", Email = "carlos@example.com", Degree = "Ing. Software", Registration = "20002020", Role = "Profesor", State = "Activo", UserImage = "night_owl.png" },
            };

        UsersListView.ItemsSource = user;
    }

    private async void OnClickedEdit(object sender, EventArgs e)
    {
        // Obtener el usuario correspondiente al bot�n presionado
        var user = (User)((Button)sender).CommandParameter;

        // Realizar la navegaci�n a la p�gina de edici�n de usuarios y pasar el usuario
        await Navigation.PushAsync(new EditUser(user));
    }

    // Controlador de eventos para el bot�n "Agregar Nuevo Usuario"
    private async void OnClickedAdd(object sender, EventArgs e)
    {
        // Navegar a la p�gina de selecci�n de rol
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
