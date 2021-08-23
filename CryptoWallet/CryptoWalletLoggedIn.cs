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
    public partial class CryptoWalletLoggedIn : Form
    {
        private CryptoWallet parent;
        private int selectedValueIndex;
        private User user;
        public CryptoWalletLoggedIn(CryptoWallet parent, User currentUser)
        {
            InitializeComponent();
            this.parent = parent;
            this.selectedValueIndex = 0;
            this.user = currentUser;
            loadHistoryData();
            currentUserLabel.Text = currentUser.username;
            lowestValueLabel.Text = "$" + parent.values[selectedValueIndex].getMin().ToString();
            highestValueLabel.Text = "$" + parent.values[selectedValueIndex].highs.Max().ToString();
        }

        private void CryptoWalletLoggedIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private void priceGraph_Paint(object sender, PaintEventArgs e)
        {
            parent.values[selectedValueIndex].draw(e.Graphics,
                priceGraph.Location.X, priceGraph.Location.Y,
                priceGraph.Location.X + priceGraph.Width, priceGraph.Location.Y + priceGraph.Height);
        }


        private void enableAllElse(int i)
        {
            if( i != 0)
            {
                btcButton.Enabled = true;
            }
            if (i != 1)
            {
                ethButton.Enabled = true;
            }
            if (i != 2)
            {
                cardanoButton.Enabled = true;
            }
            if (i != 3)
            {
                dogeButton.Enabled = true;
            }
            if (i != 4)
            {
                solButton.Enabled = true;
            }
            if (i != 5)
            {
                bchButton.Enabled = true;
            }
            if (i != 6)
            {
                vetButton.Enabled = true;
            }
            loadHistoryData();
            lowestValueLabel.Text = String.Format("{0:C5}", (1.05 * parent.values[selectedValueIndex].getMin()));
            highestValueLabel.Text = String.Format("{0:C5}", (parent.values[selectedValueIndex].highs.Max() * 0.95));

        }
        private void btcButton_Click(object sender, EventArgs e)
        {
            this.selectedValueIndex = 0;
            btcButton.Enabled = false;
            currentValueLabel.Text = "Showing stock information for Bitcoin in the last 31 day period";
            enableAllElse(0);
        }
        private void ethButton_Click(object sender, EventArgs e)
        {
            this.selectedValueIndex = 1;
            ethButton.Enabled = false;
            currentValueLabel.Text = "Showing stock information for Ethereum in the last 31 day period";
            enableAllElse(1);
            
        }

        private void cardanoButton_Click(object sender, EventArgs e)
        {
            this.selectedValueIndex = 2;
            cardanoButton.Enabled = false;
            currentValueLabel.Text = "Showing stock information for Cardano in the last 31 day period";
            enableAllElse(2);
        }

        private void dogeButton_Click(object sender, EventArgs e)
        {
            user.addAmount("btc", 10.31f);
            user.addAmount("eth", 1310.31f);
            this.selectedValueIndex = 3;
            dogeButton.Enabled = false;
            currentValueLabel.Text = "Showing stock information for DogeCoin in the last 31 day period";
            enableAllElse(3);
        }

        private void solButton_Click(object sender, EventArgs e)
        {
            this.selectedValueIndex = 4;
            bchButton.Enabled = false;
            currentValueLabel.Text = "Showing stock information for Solana in the last 31 day period";
            enableAllElse(4);
        }

        private void bchButton_Click(object sender, EventArgs e)
        {
            this.selectedValueIndex = 5;
            bchButton.Enabled = false;
            currentValueLabel.Text = "Showing stock information for BitcoinCash in the last 31 day period";
            enableAllElse(5);
        }

        private void vetButton_Click(object sender, EventArgs e)
        {

            this.selectedValueIndex = 6;
            vetButton.Enabled = false;
            currentValueLabel.Text = "Showing stock information for VeChain in the last 31 day period";
            enableAllElse(6);
        }

        private void paintTimer_Tick(object sender, EventArgs e)
        {
            priceGraph.Invalidate(true);
        }

        public void loadHistoryData()
        {
            transactionHistory.Items.Clear();
            foreach(String entry in user.history)
            {
                transactionHistory.Items.Add(entry);
            }
        }

        
    }
}
