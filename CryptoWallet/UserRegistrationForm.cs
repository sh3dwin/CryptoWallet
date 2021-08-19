using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWallet
{
    public partial class UserRegistrationForm : Form
    {
        public CryptoWallet parent;
        public UserRegistrationForm(CryptoWallet parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (parent.users.userExists(usernameTextBox.Text))
            {
                errorProvider1.SetError(usernameTextBox, "Username already exists!");
                return;
            }
            if (passTextBox.Text.Length < 6) { 
                errorProvider1.SetError(passTextBox, "Password must exceed 6 symbols!");
                return;
            }
            if (!String.Equals(passTextBox.Text, confPassTextBox.Text))
            {
                errorProvider1.SetError(confPassTextBox, "Password is not matching!");
                return;
            }
            parent.users.addUser(usernameTextBox.Text, passTextBox.Text);
            this.Close();
        }
    }
}
