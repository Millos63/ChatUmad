namespace ChatUmad
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ver_avisos());
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new avisos());
        }
    }
}