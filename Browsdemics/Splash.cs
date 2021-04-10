using Browsdemics.MediaForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browsdemics
{
    public partial class SplashFrm : Form
    {
        public SplashFrm()
        {
            InitializeComponent();
        }


        private void MediaMgrBttn_Click(object sender, EventArgs e)
        {
            MediaForm mediaForm = new MediaForm();
            mediaForm.Show();
            this.Hide();
        }

        private void SplashFrm_Load(object sender, EventArgs e)
        {
            Release();
        }

        private void Release()
        {
            CopyRightLbl.Text = $"Copyright © {DateTime.Now.Year}, made with ♡ by Lærer Labs";
            MenuGrpBx.Enabled = false;
            PreloaderImg.Visible = true;
            Waitize();
        }

        private async void Waitize()
        {
            await Task.Delay(12000);
            MenuGrpBx.Enabled = true;
            PreloaderImg.Visible = false;
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            DialogResult needConfirm = MessageBox.Show("Are you sure want to exit?", "Required Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (needConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Release();
            }
        }
    }
}
