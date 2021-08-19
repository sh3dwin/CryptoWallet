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
    public partial class CryptoWallet : Form
    {
        public UserDoc users;
        public CryptoWallet()
        {
            users = new UserDoc();
            InitializeComponent();
        }

        private void accountCreationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistrationForm form = new UserRegistrationForm(this);
            form.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (users.userExists(usernameTextBox.Text))
            {
                User currentUser = users.logInUser(usernameTextBox.Text, passwordTextBox.Text);
                if (currentUser != null)
                {
                    Close();
                }
                else
                {
                    errorProvider1.SetError(passwordTextBox, "Password incorrect!");
                }
            }
            else
            {
                errorProvider1.SetError(usernameTextBox, "Username not found!");
            }
        }
    }
}
