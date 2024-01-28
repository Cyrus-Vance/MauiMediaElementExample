namespace MauiMediaElementExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPlayButtonClicked(object sender, EventArgs e)
        {
            mediaElement.SeekTo(TimeSpan.FromSeconds(0));
            mediaElement.Play();
            mediaElement.Speed = 3;
        }
    }

}
