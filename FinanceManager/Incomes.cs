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
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void IncomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLabel2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LogoutIcon2_Click(object sender, EventArgs e)
        {

        }

        private void DashboardLabel2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void ExpenseLabel2_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Hide();
        }

        private void ViewIncomeLabel2_Click(object sender, EventArgs e)
        {
            ViewIncomes viewIncomes = new ViewIncomes();
            viewIncomes.Show();
            this.Hide();
        }

        private void ViewExpenseLabel2_Click(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses();
            viewExpenses.Show();
            this.Hide();
        }

        private void ExitIcon2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
