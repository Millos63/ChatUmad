namespace ChatUmad.Paginas;

public partial class Materias : ContentPage
{
    public Materias()
    {
        InitializeComponent();

        // Ejemplos de Materias ficticias
        var subject = new List<Subject>
            {
                new Subject { Name = "Desarrollo Web II", Code = "ISF9725", Section = "2", Group = "1", Teacher= "Roberto Fake", Credits = "10" },
                new Subject { Name = "Matematicas 2", Code = "MM29725", Section = "1", Group = "2", Teacher= "Fulanito Real", Credits = "10" },
                new Subject { Name = "Desarrollo Web II", Code = "ISF9725", Section = "2", Group = "1", Teacher= "Roberto Fake", Credits = "10" },
            };

        SubjectsListView.ItemsSource = subject;
    }


    private async void OnClickedEdit(object sender, EventArgs e)
    {
        // Obtener el usuario correspondiente al botón presionado
        var subject = (Subject)((Button)sender).CommandParameter;

        // Realizar la navegación a la página de edición de usuarios y pasar el usuario
        await Navigation.PushAsync(new EditarMateria(subject));
    }

    //Controlador de eventos para el botón "Agregar Nuevo Usuario"
    private async void OnClickedAdd(object sender, EventArgs e)
    {
        // Navegar a la página de selección de rol
        await Navigation.PushAsync(new AgregarMateria());
    }

}

public class Subject
{
    public string Name { get; internal set; }
    public string Code { get; internal set; }
    public string Section { get; internal set; }
    public string Group { get; internal set; }
    public string Teacher { get; internal set; }
    public string Credits { get; internal set; }
}
