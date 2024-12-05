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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void DashboardLabel3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void IncomeLabel3_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            incomes.Show();
            this.Hide();
        }

        private void ExpenseLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ViewIncomeLabel3_Click(object sender, EventArgs e)
        {
            ViewIncomes viewIncomes = new ViewIncomes();
            viewIncomes.Show();
            this.Hide();
        }

        private void ViewExpenseLabel3_Click(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses();
            viewExpenses.Show();
            this.Hide();
        }

        private void LogoutLabel3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ExitIcon3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
