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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginUsernameInput.Text == "" || LoginPasswordInput.Text == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else if (LoginUsernameInput.Text == "admin" && LoginPasswordInput.Text == "admin")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void LoginUsernameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
