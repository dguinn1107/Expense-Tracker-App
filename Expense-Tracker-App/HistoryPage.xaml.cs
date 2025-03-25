using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Views;

public partial class HistoryPage : ContentPage
{
    public HistoryPage()
    {
        InitializeComponent();
        LoadMockData();
    }

    private void LoadMockData()
    {
        var expenses = new List<Expense>
        {
            new Expense { Description = "Groceries", Amount = "$50", Date = DateTime.Today.AddDays(-2).ToShortDateString() },
            new Expense { Description = "Rent", Amount = "$1200", Date = DateTime.Today.AddDays(-30).ToShortDateString() },
            new Expense { Description = "Movies", Amount = "$15", Date = DateTime.Today.AddDays(-1).ToShortDateString() }
        };

        ExpensesCollectionView.ItemsSource = expenses;
    }
}

public class Expense
{
    public string Description { get; set; }
    public string Amount { get; set; }
    public string Date { get; set; }
}

