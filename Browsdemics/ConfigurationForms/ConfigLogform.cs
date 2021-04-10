using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browsdemics.ConfigurationForms
{
    public partial class ConfigLogform : Form
    {
        ConfigurationForm configFrm = null;
        private int defaultWidth = Convert.ToInt32(ConfigurationManager.AppSettings["DefaultWidth"].ToString().Trim());
        private int defaultHeight = Convert.ToInt32(ConfigurationManager.AppSettings["DefaultHeight"].ToString().Trim());

        public ConfigLogform()
        {
            DefaultSettings();
            InitializeComponent();
        }
        private void DefaultSettings()
        {
            this.Width = defaultWidth;
            this.Height = defaultHeight;
        }
        private void NewAPIBttn_Click(object sender, EventArgs e)
        {
            NewAPIForm apiRegForm = new NewAPIForm();
            this.Hide();
            apiRegForm.Show();
        }
        private void AddEndPointBttn_Click(object sender, EventArgs e)
        {
            EndpointForm endPtForm = new EndpointForm();
            this.Hide();
            endPtForm.Show();
        }

        private void LogsBttn_Click(object sender, EventArgs e)
        {
            ConfigLogform configLogForm = new ConfigLogform();
            this.Hide();
            configLogForm.Show();
        }


        private void ConfigLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenConfigHome();
        }
        private void OpenConfigHome()
        {
            if (configFrm == null || configFrm.Text == "")
            {
                configFrm = new ConfigurationForm();
                configFrm.Show();
                this.Close();
            }
            else if (CheckOpened(configFrm.Text))
            {
                configFrm.Show();
                this.Close();
                configFrm.Focus();
            }
        }
        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
