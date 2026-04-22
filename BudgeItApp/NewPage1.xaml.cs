using Android.Views;

using BudgeItApp.ViewModels;

namespace BudgeItApp;

public partial class NewPage1 : ContentPage
{
    private readonly SplitViewModel _viewModel;


    public NewPage1()
	{
		InitializeComponent();

        _viewModel = new SplitViewModel();
        BindingContext = _viewModel;
    }
    private async void GoPtwo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage2(_viewModel));
    }


    private void OnPercentagePickerChanged(object sender, EventArgs e)
    {
        if (decimal.TryParse(PaycheckAmountEntry.Text, out decimal paycheckAmount) && paycheckAmount > 0)
        {
            var selectedOption = _viewModel.SelectedPercentageOption;

            var percentages = selectedOption.Split('/').Select(int.Parse).ToArray();

            Split1Label.Text = $"Percentage 1: ${(paycheckAmount * percentages[0] / 100):0.00}";
            Split2Label.Text = $"Percentage 2: ${(paycheckAmount * percentages[1] / 100):0.00}";
            Split3Label.Text = $"Percentage 3: ${(paycheckAmount * percentages[2] / 100):0.00}";
        }
    }

}
