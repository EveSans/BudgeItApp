using Android.Views;

namespace BudgeItApp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
    }
    private async void GoPtwo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage2());
    }

}
