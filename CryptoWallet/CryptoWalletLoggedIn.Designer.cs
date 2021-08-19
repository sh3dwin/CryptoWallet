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
            this.loggedInUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loggedInUser
            // 
            this.loggedInUser.AutoSize = true;
            this.loggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInUser.Location = new System.Drawing.Point(6, 16);
            this.loggedInUser.Name = "loggedInUser";
            this.loggedInUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loggedInUser.Size = new System.Drawing.Size(138, 25);
            this.loggedInUser.TabIndex = 0;
            this.loggedInUser.Text = "placeHolder";
            this.loggedInUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.loggedInUser);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CryptoWalletLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CryptoWalletLoggedIn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CryptoWallet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CryptoWalletLoggedIn_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loggedInUser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}