namespace FinanceManager
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void IncomeLabelDshbd_Click(object sender, EventArgs e)
        {
            Incomes incomes = new Incomes();
            incomes.Show();
            this.Hide();
        }
        private void DashboardLabel_Click(object sender, EventArgs e)
        {
        }

        private void ExpenseLabel1_Click(object sender, EventArgs e)
        {
            Expenses expenses = new Expenses();
            expenses.Show();
            this.Hide();
        }

        private void ExitIcon1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewIncomeLabel1_Click(object sender, EventArgs e)
        {
            ViewIncomes viewIncomes = new ViewIncomes();
            viewIncomes.Show();
            this.Hide();
        }

        private void ViewExpenseLabel1_Click(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses();
            viewExpenses.Show();
            this.Hide();
        }

        private void LogoutLabel1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LogoutIcon1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ViewExpenseLabel1_Click_1(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses();
            viewExpenses.Show();
            this.Hide();
        }
    }
}
