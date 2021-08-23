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
        public List<CryptoValue> values;
        public CryptoWallet()
        {
            users = new UserDoc();
            values = new List<CryptoValue>();
            loadData();
            InitializeComponent();
        }

        private void accountCreationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistrationForm form = new UserRegistrationForm(this);
            form.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            this.users.loadData();
            errorProvider1.Clear();
            if (users.userExists(usernameTextBox.Text))
            {
                User currentUser = users.logInUser(usernameTextBox.Text, passwordTextBox.Text);
                if (currentUser != null)
                {
                    CryptoWalletLoggedIn form = new CryptoWalletLoggedIn(this, currentUser);
                    form.Show();
                    this.Hide();
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
        public void loadData()
        {
            this.users.loadData();
            this.values.Add(new CryptoValue("BTC"));
            this.values.Add(new CryptoValue("ETH"));
            this.values.Add(new CryptoValue("ADA"));
            this.values.Add(new CryptoValue("DOGE"));
            this.values.Add(new CryptoValue("SOL"));
            this.values.Add(new CryptoValue("BCH"));
            this.values.Add(new CryptoValue("VET"));
        }
    }
}
