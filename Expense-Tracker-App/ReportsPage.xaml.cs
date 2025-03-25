using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Views;

public partial class ReportsPage : ContentPage
{
    public ReportsPage()
    {
        InitializeComponent();
    }

    private void OnRefreshClicked(object sender, EventArgs e)
    {
        // I left it just as a random amount to fill in the meantime.
        double totalExpenses = 1265.00;
        TotalExpensesLabel.Text = $"Total Expenses: ${totalExpenses}";
    }
}
