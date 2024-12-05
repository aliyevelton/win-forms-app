using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class ViewExpenses : Form
    {
        public ViewExpenses()
        {
            InitializeComponent();
        }

        private void DashboardLabel5_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void IncomeLabel5_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            incomes.Show();
            this.Hide();
        }

        private void ExpenseLabel5_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Hide();
        }

        private void ViewIncomeLabel5_Click(object sender, EventArgs e)
        {
            ViewIncomes viewIncomes = new ViewIncomes();
            viewIncomes.Show();
            this.Hide();
        }

        private void ViewExpenseLabel5_Click(object sender, EventArgs e)
        {
        }

        private void LogoutLabel5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ExitIcon5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
