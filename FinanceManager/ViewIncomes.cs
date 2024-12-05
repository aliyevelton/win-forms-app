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
    public partial class ViewIncomes : Form
    {
        public ViewIncomes()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Dashboardlabel4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void IncomeLabel4_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            incomes.Show();
            this.Hide();
        }

        private void ExpenseLabel4_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Hide();
        }

        private void ViewIncomesLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ViewExpenseLabel4_Click(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses();
            viewExpenses.Show();
            this.Hide();
        }

        private void LogoutLabel4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ExitIcon4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
