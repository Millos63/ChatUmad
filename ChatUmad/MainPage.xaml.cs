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
            
            //await Navigation.PushAsync(new Paginas.UserList());
        }

       
    }
}