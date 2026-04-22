using BudgeItApp.ViewModels;

namespace BudgeItApp;

public partial class NewPage3 : ContentPage
{
    public NewPage3(SplitViewModel viewModel)
	{
		InitializeComponent();


        BindingContext = viewModel;


    }
    private async void GoPone(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage1());
    }
}
