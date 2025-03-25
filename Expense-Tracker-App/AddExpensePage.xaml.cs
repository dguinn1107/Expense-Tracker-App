using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Views;

public partial class AddExpensePage : ContentPage
{
    public AddExpensePage()
    {
        InitializeComponent();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        string amount = AmountEntry.Text;
        string category = CategoryPicker.SelectedItem?.ToString();
        DateTime date = DatePicker.Date;

        if (!string.IsNullOrWhiteSpace(amount) && !string.IsNullOrWhiteSpace(category))
        {
            // Save the expense
            await DisplayAlert("Success", $"Expense saved: {amount} in {category} on {date:d}", "OK");

            // Navigate back to home
            await Shell.Current.GoToAsync("//HomePage");
        }
        else
        {
            await DisplayAlert("Error", "Please enter all details.", "OK");
        }
    }
}

