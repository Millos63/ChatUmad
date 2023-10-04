namespace ChatUmad
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {

            InitializeComponent();

        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ver_avisos());
        }
        private void OnCounterClicked(object sender, EventArgs e)

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new avisos());
            
            await Navigation.PushAsync(new Paginas.Chat());
            
            //await Navigation.PushAsync(new Paginas.UserList());
        }

       
    }
}