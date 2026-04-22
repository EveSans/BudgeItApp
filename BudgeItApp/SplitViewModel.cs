using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BudgeItApp.ViewModels;

public class SplitViewModel : INotifyPropertyChanged
{
    private decimal _paycheckAmount;
    private string _selectedPercentageOption;
    private decimal _savings;
    private decimal _spending;
    private decimal _other;
    private decimal _goalAmount;

    public SplitViewModel()
    {
        PercentageOptions = new List<string> { "60/30/10", "50/30/20", "70/20/10" };
        SelectedPercentageOption = PercentageOptions[0]; // Default option
    }

    public decimal PaycheckAmount
    {
        get => _paycheckAmount;
        set
        {
            if (_paycheckAmount != value)
            {
                _paycheckAmount = value;
                OnPropertyChanged();
                CalculateSplits();
            }
        }
    }

    public List<string> PercentageOptions { get; }

    public string SelectedPercentageOption
    {
        get => _selectedPercentageOption;
        set
        {
            if (_selectedPercentageOption != value)
            {
                _selectedPercentageOption = value;
                OnPropertyChanged();
                CalculateSplits();
            }
        }
    }

    public decimal Savings
    {
        get => _savings;
        private set { _savings = value; OnPropertyChanged(); }
    }

    public decimal Spending
    {
        get => _spending;
        private set { _spending = value; OnPropertyChanged(); }
    }

    public decimal Other
    {
        get => _other;
        private set { _other = value; OnPropertyChanged(); }
    }

    public decimal GoalAmount
    {
        get => _goalAmount;
        set
        {
            if (_goalAmount != value)
            {
                _goalAmount = value;
                OnPropertyChanged();
                CalculateGoalDifference();
            }
        }
    }

    public decimal GoalDifference { get; private set; }

    private void CalculateSplits()
    {
        if (string.IsNullOrEmpty(SelectedPercentageOption) || PaycheckAmount <= 0) return;

        // Parse the selected percentage option (e.g., "60/30/10")
        var percentages = SelectedPercentageOption.Split('/').Select(int.Parse).ToArray();

        Savings = PaycheckAmount * percentages[0] / 100;
        Spending = PaycheckAmount * percentages[1] / 100;
        Other = PaycheckAmount * percentages[2] / 100;
    }

    private void CalculateGoalDifference()
    {
        GoalDifference = GoalAmount - PaycheckAmount;
        OnPropertyChanged(nameof(GoalDifference));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
