namespace Browsdemics.UserForms
{
    partial class UserMgmtForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMgmtForm));
            this.BodyWrapperPnl = new System.Windows.Forms.SplitContainer();
            this.ConfigLnk = new System.Windows.Forms.LinkLabel();
            this.BrandPicBx = new System.Windows.Forms.PictureBox();
            this.MainWrapper = new System.Windows.Forms.SplitContainer();
            this.UserRegGrpBx = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NewUserTabPg = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateUserTabPg = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DelUserTsbPg = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ServiceGridTbl = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.FieldsValidator = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BodyWrapperPnl)).BeginInit();
            this.BodyWrapperPnl.Panel1.SuspendLayout();
            this.BodyWrapperPnl.Panel2.SuspendLayout();
            this.BodyWrapperPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrandPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWrapper)).BeginInit();
            this.MainWrapper.Panel1.SuspendLayout();
            this.MainWrapper.Panel2.SuspendLayout();
            this.MainWrapper.SuspendLayout();
            this.UserRegGrpBx.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.NewUserTabPg.SuspendLayout();
            this.UpdateUserTabPg.SuspendLayout();
            this.DelUserTsbPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyWrapperPnl
            // 
            this.BodyWrapperPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BodyWrapperPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyWrapperPnl.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.BodyWrapperPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.BodyWrapperPnl.IsSplitterFixed = true;
            this.BodyWrapperPnl.Location = new System.Drawing.Point(0, 0);
            this.BodyWrapperPnl.Name = "BodyWrapperPnl";
            this.BodyWrapperPnl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BodyWrapperPnl.Panel1
            // 
            this.BodyWrapperPnl.Panel1.Controls.Add(this.ConfigLnk);
            this.BodyWrapperPnl.Panel1.Controls.Add(this.BrandPicBx);
            this.BodyWrapperPnl.Panel1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BodyWrapperPnl.Panel2
            // 
            this.BodyWrapperPnl.Panel2.Controls.Add(this.MainWrapper);
            this.BodyWrapperPnl.Size = new System.Drawing.Size(784, 461);
            this.BodyWrapperPnl.SplitterDistance = 69;
            this.BodyWrapperPnl.TabIndex = 4;
            // 
            // ConfigLnk
            // 
            this.ConfigLnk.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(179)))));
            this.ConfigLnk.AutoSize = true;
            this.ConfigLnk.BackColor = System.Drawing.Color.Transparent;
            this.ConfigLnk.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.ConfigLnk.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConfigLnk.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigLnk.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ConfigLnk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ConfigLnk.Location = new System.Drawing.Point(649, 0);
            this.ConfigLnk.Margin = new System.Windows.Forms.Padding(0);
            this.ConfigLnk.Name = "ConfigLnk";
            this.ConfigLnk.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ConfigLnk.Size = new System.Drawing.Size(135, 48);
            this.ConfigLnk.TabIndex = 13;
            this.ConfigLnk.TabStop = true;
            this.ConfigLnk.Text = "User Management System";
            this.ConfigLnk.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(204)))));
            // 
            // BrandPicBx
            // 
            this.BrandPicBx.Image = ((System.Drawing.Image)(resources.GetObject("BrandPicBx.Image")));
            this.BrandPicBx.Location = new System.Drawing.Point(12, 12);
            this.BrandPicBx.Name = "BrandPicBx";
            this.BrandPicBx.Size = new System.Drawing.Size(245, 45);
            this.BrandPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BrandPicBx.TabIndex = 0;
            this.BrandPicBx.TabStop = false;
            // 
            // MainWrapper
            // 
            this.MainWrapper.BackColor = System.Drawing.Color.Transparent;
            this.MainWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWrapper.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainWrapper.IsSplitterFixed = true;
            this.MainWrapper.Location = new System.Drawing.Point(0, 0);
            this.MainWrapper.Name = "MainWrapper";
            // 
            // MainWrapper.Panel1
            // 
            this.MainWrapper.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.MainWrapper.Panel1.Controls.Add(this.UserRegGrpBx);
            this.MainWrapper.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            // 
            // MainWrapper.Panel2
            // 
            this.MainWrapper.Panel2.Controls.Add(this.ServiceGridTbl);
            this.MainWrapper.Panel2.ForeColor = System.Drawing.Color.Transparent;
            this.MainWrapper.Size = new System.Drawing.Size(784, 388);
            this.MainWrapper.SplitterDistance = 281;
            this.MainWrapper.SplitterWidth = 2;
            this.MainWrapper.TabIndex = 1;
            // 
            // UserRegGrpBx
            // 
            this.UserRegGrpBx.Controls.Add(this.tabControl1);
            this.UserRegGrpBx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserRegGrpBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserRegGrpBx.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRegGrpBx.Location = new System.Drawing.Point(0, 0);
            this.UserRegGrpBx.Name = "UserRegGrpBx";
            this.UserRegGrpBx.Size = new System.Drawing.Size(281, 388);
            this.UserRegGrpBx.TabIndex = 0;
            this.UserRegGrpBx.TabStop = false;
            this.UserRegGrpBx.Text = "User Details";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.NewUserTabPg);
            this.tabControl1.Controls.Add(this.UpdateUserTabPg);
            this.tabControl1.Controls.Add(this.DelUserTsbPg);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // NewUserTabPg
            // 
            this.NewUserTabPg.Controls.Add(this.textBox2);
            this.NewUserTabPg.Controls.Add(this.label2);
            this.NewUserTabPg.Controls.Add(this.comboBox1);
            this.NewUserTabPg.Controls.Add(this.button1);
            this.NewUserTabPg.Controls.Add(this.textBox4);
            this.NewUserTabPg.Controls.Add(this.label4);
            this.NewUserTabPg.Controls.Add(this.label3);
            this.NewUserTabPg.Location = new System.Drawing.Point(4, 24);
            this.NewUserTabPg.Name = "NewUserTabPg";
            this.NewUserTabPg.Padding = new System.Windows.Forms.Padding(3);
            this.NewUserTabPg.Size = new System.Drawing.Size(267, 339);
            this.NewUserTabPg.TabIndex = 0;
            this.NewUserTabPg.Text = "Add User";
            this.NewUserTabPg.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 23);
            this.comboBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(194)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add &User";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(14, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(242, 22);
            this.textBox4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Access Key: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "API: ";
            // 
            // UpdateUserTabPg
            // 
            this.UpdateUserTabPg.Controls.Add(this.comboBox3);
            this.UpdateUserTabPg.Controls.Add(this.comboBox2);
            this.UpdateUserTabPg.Controls.Add(this.button2);
            this.UpdateUserTabPg.Controls.Add(this.textBox3);
            this.UpdateUserTabPg.Controls.Add(this.label5);
            this.UpdateUserTabPg.Controls.Add(this.label6);
            this.UpdateUserTabPg.Controls.Add(this.label7);
            this.UpdateUserTabPg.ForeColor = System.Drawing.Color.Black;
            this.UpdateUserTabPg.Location = new System.Drawing.Point(4, 24);
            this.UpdateUserTabPg.Name = "UpdateUserTabPg";
            this.UpdateUserTabPg.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateUserTabPg.Size = new System.Drawing.Size(267, 339);
            this.UpdateUserTabPg.TabIndex = 1;
            this.UpdateUserTabPg.Text = "Update User Details";
            this.UpdateUserTabPg.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 23);
            this.comboBox2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(194)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(14, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update &User";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(14, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 22);
            this.textBox3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Access Key: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "API: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email: ";
            // 
            // DelUserTsbPg
            // 
            this.DelUserTsbPg.Controls.Add(this.comboBox4);
            this.DelUserTsbPg.Controls.Add(this.button3);
            this.DelUserTsbPg.Controls.Add(this.label9);
            this.DelUserTsbPg.Location = new System.Drawing.Point(4, 24);
            this.DelUserTsbPg.Name = "DelUserTsbPg";
            this.DelUserTsbPg.Size = new System.Drawing.Size(267, 339);
            this.DelUserTsbPg.TabIndex = 2;
            this.DelUserTsbPg.Text = "Delete User";
            this.DelUserTsbPg.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(14, 121);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(242, 23);
            this.comboBox4.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(194)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(14, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 30);
            this.button3.TabIndex = 21;
            this.button3.Text = "Delete &User";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email: ";
            // 
            // ServiceGridTbl
            // 
            this.ServiceGridTbl.AllowUserToAddRows = false;
            this.ServiceGridTbl.AllowUserToDeleteRows = false;
            this.ServiceGridTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGridTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceGridTbl.Location = new System.Drawing.Point(0, 0);
            this.ServiceGridTbl.Name = "ServiceGridTbl";
            this.ServiceGridTbl.ReadOnly = true;
            this.ServiceGridTbl.Size = new System.Drawing.Size(501, 388);
            this.ServiceGridTbl.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(14, 116);
            this.textBox2.MaxLength = 25;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 22);
            this.textBox2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email: ";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(14, 116);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(242, 23);
            this.comboBox3.TabIndex = 20;
            // 
            // FieldsValidator
            // 
            this.FieldsValidator.ContainerControl = this;
            // 
            // UserMgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BodyWrapperPnl);
            this.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMgmtForm";
            this.Text = "User Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMgmtForm_FormClosed);
            this.BodyWrapperPnl.Panel1.ResumeLayout(false);
            this.BodyWrapperPnl.Panel1.PerformLayout();
            this.BodyWrapperPnl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BodyWrapperPnl)).EndInit();
            this.BodyWrapperPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BrandPicBx)).EndInit();
            this.MainWrapper.Panel1.ResumeLayout(false);
            this.MainWrapper.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainWrapper)).EndInit();
            this.MainWrapper.ResumeLayout(false);
            this.UserRegGrpBx.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.NewUserTabPg.ResumeLayout(false);
            this.NewUserTabPg.PerformLayout();
            this.UpdateUserTabPg.ResumeLayout(false);
            this.UpdateUserTabPg.PerformLayout();
            this.DelUserTsbPg.ResumeLayout(false);
            this.DelUserTsbPg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FieldsValidator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer BodyWrapperPnl;
        private System.Windows.Forms.PictureBox BrandPicBx;
        private System.Windows.Forms.SplitContainer MainWrapper;
        private System.Windows.Forms.DataGridView ServiceGridTbl;
        private System.Windows.Forms.LinkLabel ConfigLnk;
        private System.Windows.Forms.GroupBox UserRegGrpBx;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage NewUserTabPg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage UpdateUserTabPg;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage DelUserTsbPg;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ErrorProvider FieldsValidator;
    }
}