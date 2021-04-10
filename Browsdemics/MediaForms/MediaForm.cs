using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browsdemics.MediaForms
{
    public partial class MediaForm : Form
    {
        public MediaForm()
        {
            InitializeComponent();
        }

        private void MediaFileNewMediaMnuItm_Click(object sender, EventArgs e)
        {
            NewMedia newMedia = new NewMedia();
            newMedia.ShowDialog();
        }

        private void MediaExitMnuItm_Click(object sender, EventArgs e)
        {
            SplashFrm splash = new SplashFrm();
            splash.Show();
            this.Hide();
        }

        private void MediaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
