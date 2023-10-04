namespace ChatUmad.Paginas;

public partial class Chat : ContentPage
{
	public Chat()
	{
		InitializeComponent();
        var user = new List<User>
            {
                new User { Name = "Coordinador Carlos Zapata", Message = "Buenos días, ¿Qué necesitas?", UserImage = "coordi.png" },
                new User { Name = "Mohamed Buchahim Sierra", Message = "Hola profesor buenas tardes", UserImage = "mohamed.jpg" },
                new User { Name = "Mark Elliot Zuckerberg", Message = "Hola profesor, disculpe las molestias", UserImage = "mark.jpg" },
                new User { Name = "Armando Gonzales", Message = "Hola coordinador me podria ayudar en algo", UserImage = "armando.png" },
            };

        UsersListView.ItemsSource = user;
    }

    public class User
    {
        public string Name { get; internal set; }
        public string Message { get; internal set; }
        public string UserImage { get; set; }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}