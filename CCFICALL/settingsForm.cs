using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCFICall
{
    public partial class settingsForm : Form
    {
        private mainForm frmMain_;
        public settingsForm(mainForm frmMain)
        {
            InitializeComponent();
            frmMain_ = frmMain;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            frmMain_.SetStatus("Phone Settings Saved!");
            this.Close();
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.ipaddress = txtPhoneIP.Text;
            Properties.Settings.Default.extn = txtExt.Text;
            Properties.Settings.Default.Save();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {

        }

        private void txtExt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStoreInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
