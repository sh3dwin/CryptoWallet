﻿using System;
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
        public CryptoWallet()
        {
            InitializeComponent();
        }

        private void accountCreationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistrationForm form = new UserRegistrationForm();
            form.Show();
        }
    }
}
