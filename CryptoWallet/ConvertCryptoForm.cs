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
    public partial class ConvertCryptoForm : Form
    {
        public CryptoWalletLoggedIn parent { get; private set; }
        public User user { get; private set; }
        public ConvertCryptoForm(CryptoWalletLoggedIn parent)
        {
            this.parent = parent;
            this.user = parent.user;
            InitializeComponent();
        }

        private void convertPreviewButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(fromComboBox.Text.Equals("") || toComboBox.Text.Equals(""))
            {
                errorProvider1.SetError(toComboBox, "Please select from and to crypto currency");
                return;
            }
            if (fromComboBox.Text.Equals(toComboBox.Text))
            {
                errorProvider1.SetError(convertPreviewButton, "Cannot convert to the same currency");
                return;
            }
            if (fromTextBox.Text.Equals(""))
            {
                errorProvider1.SetError(fromTextBox, "Please enter the amount you would like to convert");
                return;
            }

            float amount = 0;
            float.TryParse(fromTextBox.Text, out amount);

            if (user.getAmount(fromComboBox.Text.ToLower()) < amount)
            {
                errorProvider1.SetError(fromTextBox, "You don't have the amount of " + fromComboBox.Text + " you entered. See available!");
                return;
            }

            float toAmount = amount * (parent.parent.getCryptoValue(fromComboBox.Text.ToLower()) / parent.parent.getCryptoValue(toComboBox.Text.ToLower()));
            toTextBox.Text = toAmount.ToString();
            convertButton.Enabled = true;
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableLabel.Text = "Available amount: " + parent.user.getAmount(fromComboBox.Text.ToLower()) + " " + fromComboBox.Text;
            fromTextBox.Text = "";
            toTextBox.Text = "";
            convertButton.Enabled = false;
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toTextBox.Text = "";
            convertButton.Enabled = false;
        }

        private void fromComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            availableLabel.Text = "Available amount: " + parent.user.getAmount(fromComboBox.Text.ToLower()) + " " + fromComboBox.Text;
            fromTextBox.Text = "";
            toTextBox.Text = "";
            convertButton.Enabled = false;
        }

        private void toComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            toTextBox.Text = "";
            convertButton.Enabled = false;
        }

        private void fromComboBox_TextUpdate(object sender, EventArgs e)
        {
            availableLabel.Text = "Available amount: " + parent.user.getAmount(fromComboBox.Text.ToLower()) + " " + fromComboBox.Text;
            fromTextBox.Text = "";
            toTextBox.Text = "";
            convertButton.Enabled = false;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            float amount = 0;
            float.TryParse(fromTextBox.Text, out amount);
            float toAmount = amount * (parent.parent.getCryptoValue(fromComboBox.Text.ToLower()) / parent.parent.getCryptoValue(toComboBox.Text.ToLower()));
            this.user.convert(fromComboBox.Text.ToLower(), amount, toComboBox.Text.ToLower(), toAmount);
            this.parent.loadHistoryData();
            this.Close();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
