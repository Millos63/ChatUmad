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
    }
}