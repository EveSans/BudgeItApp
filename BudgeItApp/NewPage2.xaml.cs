using BudgeItApp.ViewModels;


namespace BudgeItApp;

public partial class NewPage2 : ContentPage
{
    private readonly SplitViewModel _viewModel;


    public NewPage2(SplitViewModel viewModel)
	{
		InitializeComponent();

        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
    private async void GoPthree(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage3(_viewModel));
    }
}
