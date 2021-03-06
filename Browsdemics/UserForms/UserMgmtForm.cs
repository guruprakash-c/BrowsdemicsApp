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

namespace Browsdemics.UserForms
{
    public partial class UserMgmtForm : Form
    {
        private int defaultWidth = Convert.ToInt32(ConfigurationManager.AppSettings["DefaultWidth"].ToString().Trim());
        private int defaultHeight = Convert.ToInt32(ConfigurationManager.AppSettings["DefaultHeight"].ToString().Trim());

        //#0072C6 - Blue
        //#f8f8f8 -  grey
        public UserMgmtForm()
        {
            DefaultSettings();
            InitializeComponent();
        }

        private void UserMgmtForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void DefaultSettings()
        {
            this.Width = defaultWidth;
            this.Height = defaultHeight;
        }


        private DialogResult Alert(string FormTitle, string Message, MessageBoxButtons ActionButtons, MessageBoxIcon BoxIcons)
        {
            return MessageBox.Show(Message.ToString().Trim(), FormTitle.ToString().Trim(), ActionButtons, BoxIcons);
        }
    }
}