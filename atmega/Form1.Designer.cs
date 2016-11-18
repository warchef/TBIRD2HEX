namespace atmega
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HexaLabel = new System.Windows.Forms.Label();
            this.HexaOpenButton = new System.Windows.Forms.Button();
            this.COMPortLabel = new System.Windows.Forms.Label();
            this.COMPortComboBox = new System.Windows.Forms.ComboBox();
            this.WriteButton = new System.Windows.Forms.Button();
            this.CheckCMDButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CMDTextbox = new System.Windows.Forms.RichTextBox();
            this.HexSelectedLabel = new System.Windows.Forms.Label();
            this.COMSelectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HexaLabel
            // 
            this.HexaLabel.AutoSize = true;
            this.HexaLabel.Location = new System.Drawing.Point(12, 13);
            this.HexaLabel.Name = "HexaLabel";
            this.HexaLabel.Size = new System.Drawing.Size(79, 13);
            this.HexaLabel.TabIndex = 0;
            this.HexaLabel.Text = "Hexa fájl helye:";
            // 
            // HexaOpenButton
            // 
            this.HexaOpenButton.Location = new System.Drawing.Point(106, 8);
            this.HexaOpenButton.Name = "HexaOpenButton";
            this.HexaOpenButton.Size = new System.Drawing.Size(75, 23);
            this.HexaOpenButton.TabIndex = 1;
            this.HexaOpenButton.Text = "Megnyitás";
            this.HexaOpenButton.UseVisualStyleBackColor = true;
            this.HexaOpenButton.Click += new System.EventHandler(this.HexaOpenButton_Click);
            // 
            // COMPortLabel
            // 
            this.COMPortLabel.AutoSize = true;
            this.COMPortLabel.Location = new System.Drawing.Point(12, 34);
            this.COMPortLabel.Name = "COMPortLabel";
            this.COMPortLabel.Size = new System.Drawing.Size(88, 13);
            this.COMPortLabel.TabIndex = 2;
            this.COMPortLabel.Text = "COM port száma:";
            // 
            // COMPortComboBox
            // 
            this.COMPortComboBox.FormattingEnabled = true;
            this.COMPortComboBox.Location = new System.Drawing.Point(106, 31);
            this.COMPortComboBox.Name = "COMPortComboBox";
            this.COMPortComboBox.Size = new System.Drawing.Size(75, 21);
            this.COMPortComboBox.TabIndex = 3;
            this.COMPortComboBox.SelectedValueChanged += new System.EventHandler(this.COMPortComboBox_SelectedValueChanged);
            // 
            // WriteButton
            // 
            this.WriteButton.Enabled = false;
            this.WriteButton.Location = new System.Drawing.Point(191, 108);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(190, 23);
            this.WriteButton.TabIndex = 4;
            this.WriteButton.Text = "ÍRÁS";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // CheckCMDButton
            // 
            this.CheckCMDButton.Location = new System.Drawing.Point(15, 108);
            this.CheckCMDButton.Name = "CheckCMDButton";
            this.CheckCMDButton.Size = new System.Drawing.Size(170, 23);
            this.CheckCMDButton.TabIndex = 6;
            this.CheckCMDButton.Text = "Parancs megtekintése";
            this.CheckCMDButton.UseVisualStyleBackColor = true;
            this.CheckCMDButton.Click += new System.EventHandler(this.CheckCMDButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(308, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Törlés";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CMDTextbox
            // 
            this.CMDTextbox.Location = new System.Drawing.Point(15, 58);
            this.CMDTextbox.Name = "CMDTextbox";
            this.CMDTextbox.ReadOnly = true;
            this.CMDTextbox.Size = new System.Drawing.Size(368, 44);
            this.CMDTextbox.TabIndex = 8;
            this.CMDTextbox.Text = "";
            // 
            // HexSelectedLabel
            // 
            this.HexSelectedLabel.AutoSize = true;
            this.HexSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HexSelectedLabel.ForeColor = System.Drawing.Color.Lime;
            this.HexSelectedLabel.Location = new System.Drawing.Point(187, 5);
            this.HexSelectedLabel.Name = "HexSelectedLabel";
            this.HexSelectedLabel.Size = new System.Drawing.Size(100, 24);
            this.HexSelectedLabel.TabIndex = 9;
            this.HexSelectedLabel.Text = "Kiválasztva";
            this.HexSelectedLabel.Visible = false;
            // 
            // COMSelectedLabel
            // 
            this.COMSelectedLabel.AutoSize = true;
            this.COMSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.COMSelectedLabel.ForeColor = System.Drawing.Color.Lime;
            this.COMSelectedLabel.Location = new System.Drawing.Point(187, 26);
            this.COMSelectedLabel.Name = "COMSelectedLabel";
            this.COMSelectedLabel.Size = new System.Drawing.Size(100, 24);
            this.COMSelectedLabel.TabIndex = 10;
            this.COMSelectedLabel.Text = "Kiválasztva";
            this.COMSelectedLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 140);
            this.Controls.Add(this.COMSelectedLabel);
            this.Controls.Add(this.HexSelectedLabel);
            this.Controls.Add(this.CMDTextbox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CheckCMDButton);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.COMPortComboBox);
            this.Controls.Add(this.COMPortLabel);
            this.Controls.Add(this.HexaOpenButton);
            this.Controls.Add(this.HexaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HEX-TBIRD2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label HexaLabel;
        private System.Windows.Forms.Button HexaOpenButton;
        private System.Windows.Forms.Label COMPortLabel;
        private System.Windows.Forms.ComboBox COMPortComboBox;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button CheckCMDButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RichTextBox CMDTextbox;
        private System.Windows.Forms.Label HexSelectedLabel;
        private System.Windows.Forms.Label COMSelectedLabel;
    }
}

