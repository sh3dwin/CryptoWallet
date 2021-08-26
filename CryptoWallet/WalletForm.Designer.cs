namespace CryptoWallet
{
    partial class WalletForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btcLabel = new System.Windows.Forms.Label();
            this.ethLabel = new System.Windows.Forms.Label();
            this.dogeLabel = new System.Windows.Forms.Label();
            this.adaLabel = new System.Windows.Forms.Label();
            this.bchLabel = new System.Windows.Forms.Label();
            this.solLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.vetLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcLabel
            // 
            this.btcLabel.AutoSize = true;
            this.btcLabel.Location = new System.Drawing.Point(13, 13);
            this.btcLabel.Name = "btcLabel";
            this.btcLabel.Size = new System.Drawing.Size(31, 13);
            this.btcLabel.TabIndex = 0;
            this.btcLabel.Text = "BTC:";
            // 
            // ethLabel
            // 
            this.ethLabel.AutoSize = true;
            this.ethLabel.Location = new System.Drawing.Point(13, 36);
            this.ethLabel.Name = "ethLabel";
            this.ethLabel.Size = new System.Drawing.Size(32, 13);
            this.ethLabel.TabIndex = 1;
            this.ethLabel.Text = "ETH:";
            // 
            // dogeLabel
            // 
            this.dogeLabel.AutoSize = true;
            this.dogeLabel.Location = new System.Drawing.Point(13, 81);
            this.dogeLabel.Name = "dogeLabel";
            this.dogeLabel.Size = new System.Drawing.Size(41, 13);
            this.dogeLabel.TabIndex = 3;
            this.dogeLabel.Text = "DOGE:";
            // 
            // adaLabel
            // 
            this.adaLabel.AutoSize = true;
            this.adaLabel.Location = new System.Drawing.Point(13, 58);
            this.adaLabel.Name = "adaLabel";
            this.adaLabel.Size = new System.Drawing.Size(32, 13);
            this.adaLabel.TabIndex = 2;
            this.adaLabel.Text = "ADA:";
            // 
            // bchLabel
            // 
            this.bchLabel.AutoSize = true;
            this.bchLabel.Location = new System.Drawing.Point(12, 126);
            this.bchLabel.Name = "bchLabel";
            this.bchLabel.Size = new System.Drawing.Size(32, 13);
            this.bchLabel.TabIndex = 5;
            this.bchLabel.Text = "BCH:";
            // 
            // solLabel
            // 
            this.solLabel.AutoSize = true;
            this.solLabel.Location = new System.Drawing.Point(12, 103);
            this.solLabel.Name = "solLabel";
            this.solLabel.Size = new System.Drawing.Size(31, 13);
            this.solLabel.TabIndex = 4;
            this.solLabel.Text = "SOL:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(12, 200);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            // 
            // vetLabel
            // 
            this.vetLabel.AutoSize = true;
            this.vetLabel.Location = new System.Drawing.Point(13, 148);
            this.vetLabel.Name = "vetLabel";
            this.vetLabel.Size = new System.Drawing.Size(31, 13);
            this.vetLabel.TabIndex = 6;
            this.vetLabel.Text = "VET:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(112, 228);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(78, 28);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // WalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 278);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.vetLabel);
            this.Controls.Add(this.bchLabel);
            this.Controls.Add(this.solLabel);
            this.Controls.Add(this.dogeLabel);
            this.Controls.Add(this.adaLabel);
            this.Controls.Add(this.ethLabel);
            this.Controls.Add(this.btcLabel);
            this.Name = "WalletForm";
            this.Text = "Wallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btcLabel;
        private System.Windows.Forms.Label ethLabel;
        private System.Windows.Forms.Label dogeLabel;
        private System.Windows.Forms.Label adaLabel;
        private System.Windows.Forms.Label bchLabel;
        private System.Windows.Forms.Label solLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label vetLabel;
        private System.Windows.Forms.Button closeButton;
    }
}