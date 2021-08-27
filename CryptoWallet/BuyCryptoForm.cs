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
    public partial class BuyCryptoForm : Form
    {
        private CryptoWalletLoggedIn parent;
        private User user;
        private bool previewed;
        private byte selectedAmount;
        private uint timeElapsed = 0;
        public BuyCryptoForm(CryptoWalletLoggedIn cryptoWallet)
        {
            this.parent = cryptoWallet;
            this.user = cryptoWallet.user;
            this.previewed = false;
            this.selectedAmount = 0;
            this.timeElapsed = 0;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {      
            if(timeElapsed > 400 && previewButton.Text.Equals("Confirm"))
            {
                timeElapsed = 0;
                previewButton.Text = "Preview";
                previewed = false;
            }
            else
            {
                timeElapsed++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.selectedAmount = 15;
            previewed = false;
            previewButton.Text = "Preview";

            button1.BackColor = Color.PaleGreen;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.selectedAmount = 50;
            previewed = false;
            previewButton.Text = "Preview";

            button2.BackColor = Color.PaleGreen;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.selectedAmount = 100;
            previewed = false;
            previewButton.Text = "Preview";

            button3.BackColor = Color.PaleGreen;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            float cryptoAmount = (((float)this.selectedAmount) / parent.parent.getCryptoValue(getType()));
            if (comboBox1.Text == "")
            {
                errorProvider1.SetError(comboBox1, "Please select a crypto currency");
                return;
            }
            if (selectedAmount == 0)
            {
                errorProvider1.SetError(button3, "Please choose an amount");
                return;
            }
            if (previewed)
            {
                user.addAmount(getType(), cryptoAmount);
                parent.loadHistoryData();
                this.Close();
            }
            else
            {
                previewed = true;
                previewButton.Text = "Confirm";
                label3.Text = "You will receive: " + cryptoAmount.ToString() + " " + getType().ToUpper();
            }
        }

        private String getType()
        {
            Console.WriteLine(comboBox1.Text);
            switch (comboBox1.Text)
            {
                case "Bitcoin": return "btc";
                case "Ethereum": return "eth";
                case "Cardano": return "ada";
                case "DogeCoin": return "doge";
                case "Solana": return "sol";
                case "BitcoinCash": return "bch";
                case "VeChain": return "vet";
                default: return null;
            }
        }
    }
}
