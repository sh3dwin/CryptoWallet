namespace CryptoWallet
{
    partial class CryptoWalletLoggedIn
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
            this.components = new System.ComponentModel.Container();
            this.priceGraph = new System.Windows.Forms.PictureBox();
            this.btcButton = new System.Windows.Forms.Button();
            this.ethButton = new System.Windows.Forms.Button();
            this.cardanoButton = new System.Windows.Forms.Button();
            this.dogeButton = new System.Windows.Forms.Button();
            this.bchButton = new System.Windows.Forms.Button();
            this.vetButton = new System.Windows.Forms.Button();
            this.paintTimer = new System.Windows.Forms.Timer(this.components);
            this.currentCryptoLabel = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.highestValueLabel = new System.Windows.Forms.Label();
            this.lowestValueLabel = new System.Windows.Forms.Label();
            this.transactionHistory = new System.Windows.Forms.ListBox();
            this.solButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.tradeButton = new System.Windows.Forms.Button();
            this.currentValueLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // priceGraph
            // 
            this.priceGraph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceGraph.BackColor = System.Drawing.SystemColors.ControlDark;
            this.priceGraph.Location = new System.Drawing.Point(254, 85);
            this.priceGraph.Name = "priceGraph";
            this.priceGraph.Size = new System.Drawing.Size(525, 273);
            this.priceGraph.TabIndex = 2;
            this.priceGraph.TabStop = false;
            this.priceGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.priceGraph_Paint);
            // 
            // btcButton
            // 
            this.btcButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcButton.Enabled = false;
            this.btcButton.Location = new System.Drawing.Point(253, 62);
            this.btcButton.Name = "btcButton";
            this.btcButton.Size = new System.Drawing.Size(62, 23);
            this.btcButton.TabIndex = 3;
            this.btcButton.TabStop = false;
            this.btcButton.Text = "BTC";
            this.btcButton.UseVisualStyleBackColor = true;
            this.btcButton.Click += new System.EventHandler(this.btcButton_Click);
            // 
            // ethButton
            // 
            this.ethButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ethButton.Location = new System.Drawing.Point(313, 62);
            this.ethButton.Name = "ethButton";
            this.ethButton.Size = new System.Drawing.Size(62, 23);
            this.ethButton.TabIndex = 4;
            this.ethButton.TabStop = false;
            this.ethButton.Text = "ETH";
            this.ethButton.UseVisualStyleBackColor = true;
            this.ethButton.Click += new System.EventHandler(this.ethButton_Click);
            // 
            // cardanoButton
            // 
            this.cardanoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardanoButton.Location = new System.Drawing.Point(372, 62);
            this.cardanoButton.Name = "cardanoButton";
            this.cardanoButton.Size = new System.Drawing.Size(62, 23);
            this.cardanoButton.TabIndex = 5;
            this.cardanoButton.TabStop = false;
            this.cardanoButton.Text = "ADA";
            this.cardanoButton.UseVisualStyleBackColor = true;
            this.cardanoButton.Click += new System.EventHandler(this.cardanoButton_Click);
            // 
            // dogeButton
            // 
            this.dogeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dogeButton.Location = new System.Drawing.Point(431, 62);
            this.dogeButton.Name = "dogeButton";
            this.dogeButton.Size = new System.Drawing.Size(62, 23);
            this.dogeButton.TabIndex = 6;
            this.dogeButton.TabStop = false;
            this.dogeButton.Text = "DOGE";
            this.dogeButton.UseVisualStyleBackColor = true;
            this.dogeButton.Click += new System.EventHandler(this.dogeButton_Click);
            // 
            // bchButton
            // 
            this.bchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bchButton.Location = new System.Drawing.Point(551, 62);
            this.bchButton.Name = "bchButton";
            this.bchButton.Size = new System.Drawing.Size(62, 23);
            this.bchButton.TabIndex = 7;
            this.bchButton.TabStop = false;
            this.bchButton.Text = "BCH";
            this.bchButton.UseVisualStyleBackColor = true;
            this.bchButton.Click += new System.EventHandler(this.bchButton_Click);
            // 
            // vetButton
            // 
            this.vetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vetButton.Location = new System.Drawing.Point(610, 62);
            this.vetButton.Name = "vetButton";
            this.vetButton.Size = new System.Drawing.Size(62, 23);
            this.vetButton.TabIndex = 8;
            this.vetButton.TabStop = false;
            this.vetButton.Text = "VET";
            this.vetButton.UseVisualStyleBackColor = true;
            this.vetButton.Click += new System.EventHandler(this.vetButton_Click);
            // 
            // paintTimer
            // 
            this.paintTimer.Enabled = true;
            this.paintTimer.Interval = 50;
            this.paintTimer.Tick += new System.EventHandler(this.paintTimer_Tick);
            // 
            // currentCryptoLabel
            // 
            this.currentCryptoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentCryptoLabel.AutoSize = true;
            this.currentCryptoLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentCryptoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCryptoLabel.Location = new System.Drawing.Point(301, 361);
            this.currentCryptoLabel.Name = "currentCryptoLabel";
            this.currentCryptoLabel.Size = new System.Drawing.Size(429, 16);
            this.currentCryptoLabel.TabIndex = 9;
            this.currentCryptoLabel.Text = "Showing stock information for Bitcoin in the last 31 day period";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.currentUserLabel.Location = new System.Drawing.Point(6, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(168, 31);
            this.currentUserLabel.TabIndex = 10;
            this.currentUserLabel.Text = "currentUser";
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loggedInLabel.Location = new System.Drawing.Point(9, 65);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(166, 20);
            this.loggedInLabel.TabIndex = 11;
            this.loggedInLabel.Text = "Transaction history:";
            // 
            // highestValueLabel
            // 
            this.highestValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highestValueLabel.AutoSize = true;
            this.highestValueLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.highestValueLabel.Location = new System.Drawing.Point(260, 88);
            this.highestValueLabel.Name = "highestValueLabel";
            this.highestValueLabel.Size = new System.Drawing.Size(27, 13);
            this.highestValueLabel.TabIndex = 12;
            this.highestValueLabel.Text = "high";
            // 
            // lowestValueLabel
            // 
            this.lowestValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lowestValueLabel.AutoSize = true;
            this.lowestValueLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lowestValueLabel.Location = new System.Drawing.Point(672, 316);
            this.lowestValueLabel.Name = "lowestValueLabel";
            this.lowestValueLabel.Size = new System.Drawing.Size(23, 13);
            this.lowestValueLabel.TabIndex = 13;
            this.lowestValueLabel.Text = "low";
            // 
            // transactionHistory
            // 
            this.transactionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transactionHistory.FormattingEnabled = true;
            this.transactionHistory.HorizontalScrollbar = true;
            this.transactionHistory.Location = new System.Drawing.Point(12, 85);
            this.transactionHistory.Name = "transactionHistory";
            this.transactionHistory.Size = new System.Drawing.Size(224, 342);
            this.transactionHistory.TabIndex = 14;
            // 
            // solButton
            // 
            this.solButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solButton.Location = new System.Drawing.Point(491, 62);
            this.solButton.Name = "solButton";
            this.solButton.Size = new System.Drawing.Size(62, 23);
            this.solButton.TabIndex = 15;
            this.solButton.TabStop = false;
            this.solButton.Text = "SOL";
            this.solButton.UseVisualStyleBackColor = true;
            this.solButton.Click += new System.EventHandler(this.solButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(566, 385);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(94, 42);
            this.buyButton.TabIndex = 16;
            this.buyButton.Text = "Buy Crypto";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // tradeButton
            // 
            this.tradeButton.Location = new System.Drawing.Point(685, 385);
            this.tradeButton.Name = "tradeButton";
            this.tradeButton.Size = new System.Drawing.Size(94, 42);
            this.tradeButton.TabIndex = 18;
            this.tradeButton.Text = "Trade Crypto";
            this.tradeButton.UseVisualStyleBackColor = true;
            this.tradeButton.Click += new System.EventHandler(this.tradeButton_Click);
            // 
            // currentValueLabel
            // 
            this.currentValueLabel.AutoSize = true;
            this.currentValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValueLabel.Location = new System.Drawing.Point(249, 391);
            this.currentValueLabel.Name = "currentValueLabel";
            this.currentValueLabel.Size = new System.Drawing.Size(161, 25);
            this.currentValueLabel.TabIndex = 19;
            this.currentValueLabel.Text = "Current value:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.Location = new System.Drawing.Point(405, 391);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(136, 25);
            this.valueLabel.TabIndex = 20;
            this.valueLabel.Text = "$0000.0000";
            // 
            // CryptoWalletLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.currentValueLabel);
            this.Controls.Add(this.tradeButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.solButton);
            this.Controls.Add(this.transactionHistory);
            this.Controls.Add(this.lowestValueLabel);
            this.Controls.Add(this.highestValueLabel);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.currentCryptoLabel);
            this.Controls.Add(this.vetButton);
            this.Controls.Add(this.bchButton);
            this.Controls.Add(this.dogeButton);
            this.Controls.Add(this.cardanoButton);
            this.Controls.Add(this.ethButton);
            this.Controls.Add(this.btcButton);
            this.Controls.Add(this.priceGraph);
            this.Name = "CryptoWalletLoggedIn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CryptoWallet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CryptoWalletLoggedIn_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.priceGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox priceGraph;
        private System.Windows.Forms.Button btcButton;
        private System.Windows.Forms.Button ethButton;
        private System.Windows.Forms.Button cardanoButton;
        private System.Windows.Forms.Button dogeButton;
        private System.Windows.Forms.Button bchButton;
        private System.Windows.Forms.Button vetButton;
        private System.Windows.Forms.Timer paintTimer;
        private System.Windows.Forms.Label currentCryptoLabel;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.Label highestValueLabel;
        private System.Windows.Forms.Label lowestValueLabel;
        private System.Windows.Forms.ListBox transactionHistory;
        private System.Windows.Forms.Button solButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button tradeButton;
        private System.Windows.Forms.Label currentValueLabel;
        private System.Windows.Forms.Label valueLabel;
    }
}