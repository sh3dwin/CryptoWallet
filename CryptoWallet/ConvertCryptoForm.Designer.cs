namespace CryptoWallet
{
    partial class ConvertCryptoForm
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
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.convertPreviewButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.cancleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fromComboBox
            // 
            this.fromComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "BTC",
            "ETH",
            "ADA",
            "DOGE",
            "SOL",
            "BCH",
            "VET"});
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Items.AddRange(new object[] {
            "BTC",
            "ETH",
            "ADA",
            "DOGE",
            "SOL",
            "BCH",
            "VET"});
            this.fromComboBox.Location = new System.Drawing.Point(31, 43);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(113, 21);
            this.fromComboBox.TabIndex = 0;
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            this.fromComboBox.SelectionChangeCommitted += new System.EventHandler(this.fromComboBox_SelectionChangeCommitted);
            this.fromComboBox.TextUpdate += new System.EventHandler(this.fromComboBox_TextUpdate);
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] {
            "BTC",
            "ETH",
            "ADA",
            "DOGE",
            "SOL",
            "BCH",
            "VET"});
            this.toComboBox.Location = new System.Drawing.Point(260, 43);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(121, 21);
            this.toComboBox.TabIndex = 1;
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBox_SelectedIndexChanged);
            this.toComboBox.SelectionChangeCommitted += new System.EventHandler(this.toComboBox_SelectionChangeCommitted);
            // 
            // convertPreviewButton
            // 
            this.convertPreviewButton.BackColor = System.Drawing.Color.White;
            this.convertPreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertPreviewButton.Location = new System.Drawing.Point(166, 43);
            this.convertPreviewButton.Name = "convertPreviewButton";
            this.convertPreviewButton.Size = new System.Drawing.Size(75, 65);
            this.convertPreviewButton.TabIndex = 2;
            this.convertPreviewButton.Text = "<=>";
            this.convertPreviewButton.UseVisualStyleBackColor = false;
            this.convertPreviewButton.Click += new System.EventHandler(this.convertPreviewButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Location = new System.Drawing.Point(123, 145);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 33);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // cancleButton
            // 
            this.cancleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancleButton.Location = new System.Drawing.Point(204, 145);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(74, 33);
            this.cancleButton.TabIndex = 4;
            this.cancleButton.Text = "Cancel";
            this.cancleButton.UseVisualStyleBackColor = false;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(31, 88);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(113, 20);
            this.fromTextBox.TabIndex = 7;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(260, 88);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(121, 20);
            this.toTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter the amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount you will receive";
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(31, 114);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(53, 13);
            this.availableLabel.TabIndex = 11;
            this.availableLabel.Text = "Available:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConvertCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(408, 185);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertPreviewButton);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Name = "ConvertCryptoForm";
            this.Text = "Convert";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.Button convertPreviewButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}