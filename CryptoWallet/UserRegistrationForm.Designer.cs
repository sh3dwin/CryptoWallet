namespace CryptoWallet
{
    partial class UserRegistrationForm
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
            this.regUsernameLabel = new System.Windows.Forms.Label();
            this.regPasswordLabel = new System.Windows.Forms.Label();
            this.regConfPasswordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // regUsernameLabel
            // 
            this.regUsernameLabel.AutoSize = true;
            this.regUsernameLabel.Location = new System.Drawing.Point(38, 21);
            this.regUsernameLabel.Name = "regUsernameLabel";
            this.regUsernameLabel.Size = new System.Drawing.Size(93, 13);
            this.regUsernameLabel.TabIndex = 0;
            this.regUsernameLabel.Text = "Enter a username:";
            // 
            // regPasswordLabel
            // 
            this.regPasswordLabel.AutoSize = true;
            this.regPasswordLabel.Location = new System.Drawing.Point(38, 87);
            this.regPasswordLabel.Name = "regPasswordLabel";
            this.regPasswordLabel.Size = new System.Drawing.Size(83, 13);
            this.regPasswordLabel.TabIndex = 1;
            this.regPasswordLabel.Text = "Enter password:";
            // 
            // regConfPasswordLabel
            // 
            this.regConfPasswordLabel.AutoSize = true;
            this.regConfPasswordLabel.Location = new System.Drawing.Point(38, 134);
            this.regConfPasswordLabel.Name = "regConfPasswordLabel";
            this.regConfPasswordLabel.Size = new System.Drawing.Size(93, 13);
            this.regConfPasswordLabel.TabIndex = 2;
            this.regConfPasswordLabel.Text = "Confirm password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(41, 186);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(161, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Create Account";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(100, 212);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cancel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 244);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.regConfPasswordLabel);
            this.Controls.Add(this.regPasswordLabel);
            this.Controls.Add(this.regUsernameLabel);
            this.Name = "UserRegistrationForm";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regUsernameLabel;
        private System.Windows.Forms.Label regPasswordLabel;
        private System.Windows.Forms.Label regConfPasswordLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}