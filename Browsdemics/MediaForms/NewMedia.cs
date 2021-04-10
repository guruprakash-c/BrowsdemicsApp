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
    public partial class NewMedia : Form
    {
        ToolTip notifyer = new ToolTip();
        public NewMedia()
        {
            notifyer.ToolTipTitle = this.Text;
            notifyer.UseAnimation = true;
            notifyer.UseFading = true;
            notifyer.BackColor = ColorTranslator.FromHtml("#ffffc4");
            notifyer.ForeColor = ColorTranslator.FromHtml("#212221");
            InitializeComponent();
        }

        private void FromDateTxtBx_ValueChanged(object sender, EventArgs e)
        {
            if(FromDateTxtBx.Value != null)
            {
                FieldsValidator.Clear();
                notifyer.RemoveAll();
                ToDateTxtBx.MinDate = FromDateTxtBx.Value;
            }
            else
            {
                notifyer.IsBalloon = true;
                notifyer.SetToolTip(FromDateTxtBx, "Invalid From Date!");
                FieldsValidator.SetError(FromDateTxtBx, "Invalid From Date!");
                FieldsValidator.Icon = new Icon(SystemIcons.Error, 16, 16);
            }
        }

        private void DiscardBttn_Click(object sender, EventArgs e)
        {
            UserEmailTxtBx.Text = string.Empty;
            MediaTxtBx.Text = string.Empty;
            AccessKeyTxtBx.Text = string.Empty;
            EndPtUrlTxtBx.Text = string.Empty;
            KywdsTxtBx.Text = string.Empty;
            LangTxtBx.Text = string.Empty;
            CountryTxtBx.Text = string.Empty;
            CategoryTxtBx.Text = string.Empty;
            FindInTxtBx.Text = string.Empty;
            SortByTxtBx.Text = string.Empty;
            FromDateTxtBx.Text = DateTime.Now.ToLongTimeString();
            ToDateTxtBx.Text = DateTime.Now.ToLongTimeString();
            MaxReqTxtBx.Text = string.Empty;
            ReqLimitTxtBx.Text = string.Empty;
            NullChkBx.Checked = false;
            MediaStatusChkBx.Checked = true;
        }

        private void RegMediaBttn_Click(object sender, EventArgs e)
        {
            string userEmail = string.Empty;
            if (string.IsNullOrEmpty(UserEmailTxtBx.Text))
            {
                notifyer.IsBalloon = true;
                notifyer.SetToolTip(UserEmailTxtBx, "Please provide the associated account email address.");
                FieldsValidator.SetError(UserEmailTxtBx, "Please provide the associated account email address.");
                FieldsValidator.Icon = new Icon(SystemIcons.Error, 16, 16);
            }
            else
            {
                userEmail = UserEmailTxtBx.Text.ToString();
                notifyer.RemoveAll();
                FieldsValidator.Clear();
            }
            string mediaName = string.Empty;
            if (string.IsNullOrEmpty(MediaTxtBx.Text))
            {
                notifyer.IsBalloon = true;
                notifyer.SetToolTip(MediaTxtBx, "Please provide the name of the media to register.");
                FieldsValidator.SetError(MediaTxtBx, "Please provide the name of the media to register.");
                FieldsValidator.Icon = new Icon(SystemIcons.Error, 16, 16);
            }
            else
            {
                mediaName = MediaTxtBx.Text.ToString();
                FieldsValidator.Clear();
                notifyer.RemoveAll();
            }
            if (userEmail != string.Empty && mediaName != string.Empty)
            {
                MessageBox.Show($"\"{mediaName}\" has been successfully registered. You can access its endpoints.","Success!",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show($"Unable to register, some field(s) is/are missing. Please check it and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserEmailTxtBx_TextChanged(object sender, EventArgs e)
        {
            bool isValidEmail = false;
            if (!string.IsNullOrEmpty(UserEmailTxtBx.Text))
            {
                try
                {
                    System.Net.Mail.MailAddress mailAddress = new System.Net.Mail.MailAddress(UserEmailTxtBx.Text);
                    isValidEmail = mailAddress.Host.Contains(".");
                    if (!isValidEmail)
                    {
                        notifyer.IsBalloon = true;
                        notifyer.SetToolTip(UserEmailTxtBx, "Please provide a valid email address.");
                        FieldsValidator.SetError(UserEmailTxtBx, "Please provide a valid email address.");
                        FieldsValidator.Icon = new Icon(SystemIcons.Error, 10, 10);
                    }
                    else
                    {
                        FieldsValidator.Clear();
                        notifyer.RemoveAll();
                    }
                }
                catch (Exception)
                {
                    notifyer.IsBalloon = true;
                    notifyer.SetToolTip(UserEmailTxtBx, "Please provide a valid email address.");
                    FieldsValidator.SetError(UserEmailTxtBx, "Please provide a valid email address.");
                    FieldsValidator.Icon = new Icon(SystemIcons.Error, 10, 10);
                }
            }
        }

        private void EndPtUrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EndPtUrlTxtBx.Text))
            {
                try
                {
                    Uri uriResult;
                    bool isValidUrl = Uri.TryCreate(EndPtUrlTxtBx.Text, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                    if (isValidUrl != true)
                    {
                        notifyer.IsBalloon = true;
                        notifyer.SetToolTip(EndPtUrlTxtBx, "Please provide a valid media endpoint url.");
                        FieldsValidator.SetError(EndPtUrlTxtBx, "Please provide a valid media endpoint url.");
                        FieldsValidator.Icon = new Icon(SystemIcons.Error, 16, 16);
                    }
                    else
                    {
                        FieldsValidator.Clear();
                        notifyer.RemoveAll();
                    }
                }
                catch (Exception)
                {
                    notifyer.IsBalloon = true;
                    notifyer.SetToolTip(EndPtUrlTxtBx, "Please provide a valid media endpoint url.");
                    FieldsValidator.SetError(EndPtUrlTxtBx, "Please provide a valid media endpoint url.");
                    FieldsValidator.Icon = new Icon(SystemIcons.Error, 16, 16);
                }
            }
        }
    }
}
