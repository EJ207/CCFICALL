namespace CCFICall
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.syncTextBox1 = new CCFICall.SyncTextBox();
            this.syncTextBox2 = new CCFICall.SyncTextBox();
            this.btnStoreInfo = new System.Windows.Forms.Button();
            this.btnSavePhoneSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone IP:";
            // 
            // txtPhoneIP
            // 
            this.txtPhoneIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CCFICall.Properties.Settings.Default, "ipaddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPhoneIP.Location = new System.Drawing.Point(91, 53);
            this.txtPhoneIP.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhoneIP.Name = "txtPhoneIP";
            this.txtPhoneIP.Size = new System.Drawing.Size(120, 22);
            this.txtPhoneIP.TabIndex = 17;
            this.txtPhoneIP.Text = global::CCFICall.Properties.Settings.Default.ipaddress;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your Ext.";
            // 
            // txtExt
            // 
            this.txtExt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CCFICall.Properties.Settings.Default, "extn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExt.Location = new System.Drawing.Point(91, 17);
            this.txtExt.Margin = new System.Windows.Forms.Padding(5);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(120, 22);
            this.txtExt.TabIndex = 15;
            this.txtExt.Text = global::CCFICall.Properties.Settings.Default.extn;
            // 
            // syncTextBox1
            // 
            this.syncTextBox1.Buddy = this.syncTextBox2;
            this.syncTextBox1.Location = new System.Drawing.Point(12, 120);
            this.syncTextBox1.Multiline = true;
            this.syncTextBox1.Name = "syncTextBox1";
            this.syncTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.syncTextBox1.Size = new System.Drawing.Size(68, 160);
            this.syncTextBox1.TabIndex = 23;
            this.syncTextBox1.Text = resources.GetString("syncTextBox1.Text");
            // 
            // syncTextBox2
            // 
            this.syncTextBox2.Buddy = this.syncTextBox1;
            this.syncTextBox2.Location = new System.Drawing.Point(91, 120);
            this.syncTextBox2.Multiline = true;
            this.syncTextBox2.Name = "syncTextBox2";
            this.syncTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.syncTextBox2.Size = new System.Drawing.Size(120, 160);
            this.syncTextBox2.TabIndex = 24;
            this.syncTextBox2.Text = resources.GetString("syncTextBox2.Text");
            // 
            // btnStoreInfo
            // 
            this.btnStoreInfo.Location = new System.Drawing.Point(24, 293);
            this.btnStoreInfo.Name = "btnStoreInfo";
            this.btnStoreInfo.Size = new System.Drawing.Size(176, 23);
            this.btnStoreInfo.TabIndex = 25;
            this.btnStoreInfo.Text = "Save Store Info";
            this.btnStoreInfo.UseVisualStyleBackColor = true;
            // 
            // btnSavePhoneSettings
            // 
            this.btnSavePhoneSettings.Location = new System.Drawing.Point(24, 83);
            this.btnSavePhoneSettings.Name = "btnSavePhoneSettings";
            this.btnSavePhoneSettings.Size = new System.Drawing.Size(176, 23);
            this.btnSavePhoneSettings.TabIndex = 26;
            this.btnSavePhoneSettings.Text = "Save Phone Settings";
            this.btnSavePhoneSettings.UseVisualStyleBackColor = true;
            this.btnSavePhoneSettings.Click += new System.EventHandler(this.btnSavePhoneSettings_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 328);
            this.Controls.Add(this.btnSavePhoneSettings);
            this.Controls.Add(this.btnStoreInfo);
            this.Controls.Add(this.syncTextBox2);
            this.Controls.Add(this.syncTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExt;
        private SyncTextBox syncTextBox1;
        private SyncTextBox syncTextBox2;
        private System.Windows.Forms.Button btnStoreInfo;
        private System.Windows.Forms.Button btnSavePhoneSettings;
    }
}