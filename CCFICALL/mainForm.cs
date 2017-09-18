﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCFICall
{
    public partial class mainForm : Form
    {
       
        public mainForm()
        {
            InitializeComponent();
        }

        public async void HTTP_GET(string callto, string phoneip, string extn)
        {
            var TARGETURL = "http://"+phoneip+"/servlet?key=number="+callto+"&outgoing_uri="+extn+"@"+phoneip;
            HttpClientHandler handler = new HttpClientHandler()
            {
                UseDefaultCredentials = true
            };     
            HttpClient client = new HttpClient(handler);
            var byteArray = Encoding.ASCII.GetBytes("user:user");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            try
            {
                HttpResponseMessage response = await client.GetAsync(TARGETURL);
                HttpContent content = response.Content;
                if ((int)response.StatusCode == 200)
                    SetStatus("Auth Success! Calling " + callto);
                else
                    SetStatus("Error " + (int)response.StatusCode + " ..(Bad Auth)..Try Again");
            }
            catch(Exception ex)
            {
               SetStatus("Error: Bad Input Data");
            }           
        }
        public async void PhoneAction(string phoneip, string phoneaction)
        {
            var TARGETURL = "http://" + phoneip + "/servlet?key="+phoneaction;
            HttpClientHandler handler = new HttpClientHandler()
            {
                UseDefaultCredentials = true
            };
            HttpClient client = new HttpClient(handler);
            var byteArray = Encoding.ASCII.GetBytes("user:user");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            try
            {
                HttpResponseMessage response = await client.GetAsync(TARGETURL);
                HttpContent content = response.Content;
                if ((int)response.StatusCode == 200)
                    SetStatus("Auth Success! Hanging up ");
                else
                    SetStatus("Error " + (int)response.StatusCode + " ..(Bad Auth)..Try Again");
            }
            catch (Exception ex)
            {
                SetStatus("Error: Bad Input Data");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " +Environment.UserName;       
        }

        private void cBCall_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBStore.SelectedIndex = cBCall.SelectedIndex;
            FilterCallto();
        }

        private void cBStore_SelectedIndexChanged(object sender, EventArgs e)
        {
               cBCall.SelectedIndex = cBStore.SelectedIndex;
            FilterCallto();
         
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            FilterCallto();
            HTTP_GET(cBCall.Text, Properties.Settings.Default.ipaddress, Properties.Settings.Default.extn);
        }

        private void cBCall_TextUpdate(object sender, EventArgs e)
        {
            FilterCallto();
        }

        private void cBCall_TextChanged(object sender, EventArgs e)
        {
            FilterCallto();
        }

        public void SetStatus(string text)
        {
            stsLbl.Text = text;
            m_timer.Stop();
            m_timer.Start();
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            stsLbl.Text = "Idle";
            m_timer.Stop();
        }
        private void FilterCallto()
        {
            var output = Regex.Replace(cBCall.Text, @"[^0-9]", "");
            cBCall.Text = output;
        }

        private void btnHangup_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "CANCEL");
            SetStatus("Hanging up..");
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "HOLD");
            SetStatus("Holding..");
            btnHold.Visible = false;
            btnUnhold.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "L2");
            SetStatus("Logging in..");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, txtTestAction.Text);
            SetStatus("Testing action: "+txtTestAction.Text);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "ANSWER");
            SetStatus("Answering..");
        }

        private void phoneSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm sForm = new settingsForm(this);
            sForm.Show();
        }

        private void btnUnhold_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "UNHOLD");
            SetStatus("Unholding..");
            btnHold.Visible = true;
            btnUnhold.Visible = false;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "MUTE");
            SetStatus("Muting..");
            btnMute.Visible = false;
            btnUnmute.Visible = true;
        }

        private void btnUnmute_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "MUTE");
            SetStatus("Unmuting..");
            btnMute.Visible = true;
            btnUnmute.Visible = false;
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "RD");
            SetStatus("Redialing..");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "L#");
            SetStatus("Logging out..");
        }

        private void brnTransfer_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "BTrans="+cbTransfer.Text);
            SetStatus("Transfering to "+cbTransfer.Text);
        }

        private void btnVolUp_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "VOLUME_UP");
            SetStatus("Increasing Volume..");
        }

        private void btnVolDn_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "VOLUME_DOWN");
            SetStatus("Decreasing Volume..");
        }

        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "SPEAKER");
            SetStatus("Speakerphone..");
        }

        private void btnHeadset_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "HEADSET");
            SetStatus("Headset Mode..");
        }
        private void btnConf_Click(object sender, EventArgs e)
        {
            PhoneAction(Properties.Settings.Default.ipaddress, "F_CONFERENCE");
            HTTP_GET(cbTransfer.Text, Properties.Settings.Default.ipaddress, Properties.Settings.Default.extn);
            SetStatus("Conference to " + cbTransfer.Text);
        }

    }
}
