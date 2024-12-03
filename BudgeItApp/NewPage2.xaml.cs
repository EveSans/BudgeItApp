namespace BudgeItApp;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
    private async void GoPthree(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage3());
    }
}