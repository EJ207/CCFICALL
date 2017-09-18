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
            this.button1 = new VistaButton.VistaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.btnStoreInfo = new VistaButton.VistaButton();
            this.syncTextBox1 = new CCFICall.SyncTextBox();
            this.syncTextBox2 = new CCFICall.SyncTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save Phone Settings";
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.txtExt.TextChanged += new System.EventHandler(this.txtExt_TextChanged);
            // 
            // btnStoreInfo
            // 
            this.btnStoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnStoreInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnStoreInfo.ForeColor = System.Drawing.Color.White;
            this.btnStoreInfo.Location = new System.Drawing.Point(24, 287);
            this.btnStoreInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnStoreInfo.Name = "btnStoreInfo";
            this.btnStoreInfo.Size = new System.Drawing.Size(176, 28);
            this.btnStoreInfo.TabIndex = 20;
            this.btnStoreInfo.Text = "Save Store Info";
            this.btnStoreInfo.Click += new System.EventHandler(this.btnStoreInfo_Click);
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
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 328);
            this.Controls.Add(this.syncTextBox2);
            this.Controls.Add(this.syncTextBox1);
            this.Controls.Add(this.btnStoreInfo);
            this.Controls.Add(this.button1);
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
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VistaButton.VistaButton button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExt;
        private VistaButton.VistaButton btnStoreInfo;
        private SyncTextBox syncTextBox1;
        private SyncTextBox syncTextBox2;
    }
}