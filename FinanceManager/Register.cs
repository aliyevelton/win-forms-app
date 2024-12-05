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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void LoginUsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (RegisterUsernameInput.Text == "" || FullNameInput.Text == "" || PasswordInput.Text == "" || ConfirmPasswordLabel.Text == "")
            {
                MessageBox.Show("All fields are required.");
            }
            else if (PasswordInput.Text != ConfirmPasswordInput.Text)
            {
                MessageBox.Show("Passwords do not match.");
            }
            else
            {
                MessageBox.Show("Account created successfully.");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
