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
    public partial class WalletForm : Form
    {
        public CryptoWalletLoggedIn parent { get; private set; }
        public WalletForm(CryptoWalletLoggedIn parent)
        {
            this.parent = parent;
            InitializeComponent();
            show();
        }
        public void show()
        {
            float total = 0;
            float btc = parent.parent.getCryptoValue("btc") * parent.user.wallet.btcAmount;
            float eth = parent.parent.getCryptoValue("eth") * parent.user.wallet.ethAmount;
            float ada = parent.parent.getCryptoValue("ada") * parent.user.wallet.adaAmount;
            float doge = parent.parent.getCryptoValue("doge") * parent.user.wallet.dogeAmount;
            float sol = parent.parent.getCryptoValue("sol") * parent.user.wallet.solAmount;
            float bch = parent.parent.getCryptoValue("bch") * parent.user.wallet.bchAmount;
            float vet = parent.parent.getCryptoValue("vet") * parent.user.wallet.vetAmount;
            total = btc + eth + sol + ada + doge + bch + vet;
            Console.WriteLine(btc);
            Console.WriteLine(eth);
            Console.WriteLine(ada);
            Console.WriteLine(doge);
            Console.WriteLine(sol);
            Console.WriteLine(bch);
            Console.WriteLine(vet);
             btcLabel.Text = string.Format("{0,-5}{1,10:F5}, {2,8:C2}", "BTC: ", parent.user.wallet.btcAmount, btc);
             ethLabel.Text = string.Format("{0,-5}{1,10:F5}, {2,8:C2}", "ETH: ", parent.user.wallet.ethAmount, eth);
             adaLabel.Text = string.Format("{0,-5}{1,10:F5}, {2,8:C2}", "ADA: ", parent.user.wallet.adaAmount, ada);
            dogeLabel.Text = string.Format("{0,-5}{1,10:F5}, {2,8:C2}", "DOGE:", parent.user.wallet.dogeAmount, doge);
             solLabel.Text = string.Format("{0,-5}{1,10:F5}, {2,8:C2}", "SOL: ", parent.user.wallet.solAmount, sol);
             bchLabel.Text = string.Format("{0,-5}{1,10:F5}, {2,8:C2}", "BCH: ", parent.user.wallet.bchAmount, bch);
             vetLabel.Text = string.Format("{0,-5}{1,10:F5}, {2,8:C2}", "VET: ", parent.user.wallet.vetAmount, vet);

            totalLabel.Text = string.Format("Total: {0:C2}", total);
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
