using System;
using System.Windows.Forms;

namespace CCFICall
{
    public partial class settingsForm : Form
    {
        private mainForm frmMain_;

        /** 
         * <summary> SettingsForm Intialized within mainForm.cs scope</summary>
         * <remarks>
         *   This is to allow accessing mainForm.cs public scope, so setting the statusStrip text is possible.
         * </remarks>
         */
        public settingsForm(mainForm frmMain)
        {
            InitializeComponent();
            frmMain_ = frmMain;
            //Phone settings are loaded from Application Settings and set utilizing ApplicationSetting Property Binding on txtPhoneIP and txtExt textboxes
        }

        /** 
         * <summary> Save Desk Phone settings</summary>
         * <remarks>
         *    These settings are stored in %USERPROFILE%/AppData/Local/CCFI/CCFICall.exe_Url_XXXXXX/App_Version/user.config
         * </remarks>
         */
        private void SaveSettings()
        {
            Properties.Settings.Default.ipaddress = txtPhoneIP.Text;
            Properties.Settings.Default.extn = txtExt.Text;
            Properties.Settings.Default.Save();
        }

        private void btnSavePhoneSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
            frmMain_.SetStatus("Phone Settings Saved!");
            this.Close();
        }
    }
}
