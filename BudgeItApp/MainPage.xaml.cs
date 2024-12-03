namespace BudgeItApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoPone(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }
    }

}
