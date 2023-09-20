namespace ChatUmad
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {

            InitializeComponent();

        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new Paginas.Chat());
            SemanticScreenReader.Announce(CounterBtn.Text);
            //await Navigation.PushAsync(new Paginas.UserList());
        }

            SemanticScreenReader.Announce(CounterBtn.Text);

            //await Navigation.PushAsync(new Paginas.UserList());
        }
    }
}