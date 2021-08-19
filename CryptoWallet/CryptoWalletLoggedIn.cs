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
        private User user;
        public CryptoWalletLoggedIn(CryptoWallet parent, User currentUser)
        {
            InitializeComponent();
            this.parent = parent;
            this.user = currentUser;
            loggedInUser.Text = user.username;
        }

        private void CryptoWalletLoggedIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
    }
}
