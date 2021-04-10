namespace Browsdemics.ConfigurationForms
{
    partial class EndpointForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndpointForm));
            this.BodyWrapperPnl = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.EndPtLnk = new System.Windows.Forms.LinkLabel();
            this.ConfigLnk = new System.Windows.Forms.LinkLabel();
            this.BrandPicBx = new System.Windows.Forms.PictureBox();
            this.MainWrapper = new System.Windows.Forms.SplitContainer();
            this.MenuPnl = new System.Windows.Forms.TableLayoutPanel();
            this.AddEndPointBttn = new System.Windows.Forms.Button();
            this.NewAPIBttn = new System.Windows.Forms.Button();
            this.LogsBttn = new System.Windows.Forms.Button();
            this.ServiceGridTbl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BodyWrapperPnl)).BeginInit();
            this.BodyWrapperPnl.Panel1.SuspendLayout();
            this.BodyWrapperPnl.Panel2.SuspendLayout();
            this.BodyWrapperPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrandPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWrapper)).BeginInit();
            this.MainWrapper.Panel1.SuspendLayout();
            this.MainWrapper.Panel2.SuspendLayout();
            this.MainWrapper.SuspendLayout();
            this.MenuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridTbl)).BeginInit();
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
            this.BodyWrapperPnl.Panel1.Controls.Add(this.label2);
            this.BodyWrapperPnl.Panel1.Controls.Add(this.EndPtLnk);
            this.BodyWrapperPnl.Panel1.Controls.Add(this.ConfigLnk);
            this.BodyWrapperPnl.Panel1.Controls.Add(this.BrandPicBx);
            // 
            // BodyWrapperPnl.Panel2
            // 
            this.BodyWrapperPnl.Panel2.Controls.Add(this.MainWrapper);
            this.BodyWrapperPnl.Size = new System.Drawing.Size(784, 461);
            this.BodyWrapperPnl.SplitterDistance = 69;
            this.BodyWrapperPnl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(333, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "\\";
            // 
            // EndPtLnk
            // 
            this.EndPtLnk.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(179)))));
            this.EndPtLnk.AutoSize = true;
            this.EndPtLnk.BackColor = System.Drawing.Color.Transparent;
            this.EndPtLnk.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.EndPtLnk.Enabled = false;
            this.EndPtLnk.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndPtLnk.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.EndPtLnk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.EndPtLnk.Location = new System.Drawing.Point(351, 34);
            this.EndPtLnk.Margin = new System.Windows.Forms.Padding(0);
            this.EndPtLnk.Name = "EndPtLnk";
            this.EndPtLnk.Size = new System.Drawing.Size(132, 13);
            this.EndPtLnk.TabIndex = 9;
            this.EndPtLnk.TabStop = true;
            this.EndPtLnk.Text = "API Endpoint Registration";
            this.EndPtLnk.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(204)))));
            // 
            // ConfigLnk
            // 
            this.ConfigLnk.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(179)))));
            this.ConfigLnk.AutoSize = true;
            this.ConfigLnk.BackColor = System.Drawing.Color.Transparent;
            this.ConfigLnk.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.ConfigLnk.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigLnk.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ConfigLnk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ConfigLnk.Location = new System.Drawing.Point(260, 33);
            this.ConfigLnk.Margin = new System.Windows.Forms.Padding(0);
            this.ConfigLnk.Name = "ConfigLnk";
            this.ConfigLnk.Size = new System.Drawing.Size(72, 13);
            this.ConfigLnk.TabIndex = 8;
            this.ConfigLnk.TabStop = true;
            this.ConfigLnk.Text = "Configuration";
            this.ConfigLnk.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(204)))));
            this.ConfigLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConfigLnk_LinkClicked);
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
            this.MainWrapper.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.MainWrapper.Panel1.Controls.Add(this.MenuPnl);
            // 
            // MainWrapper.Panel2
            // 
            this.MainWrapper.Panel2.Controls.Add(this.ServiceGridTbl);
            this.MainWrapper.Panel2.ForeColor = System.Drawing.Color.Transparent;
            this.MainWrapper.Size = new System.Drawing.Size(784, 388);
            this.MainWrapper.SplitterDistance = 260;
            this.MainWrapper.SplitterWidth = 2;
            this.MainWrapper.TabIndex = 1;
            // 
            // MenuPnl
            // 
            this.MenuPnl.ColumnCount = 1;
            this.MenuPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MenuPnl.Controls.Add(this.AddEndPointBttn, 0, 2);
            this.MenuPnl.Controls.Add(this.NewAPIBttn, 0, 1);
            this.MenuPnl.Controls.Add(this.LogsBttn, 0, 3);
            this.MenuPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPnl.Location = new System.Drawing.Point(0, 0);
            this.MenuPnl.Name = "MenuPnl";
            this.MenuPnl.RowCount = 4;
            this.MenuPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MenuPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MenuPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MenuPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.MenuPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuPnl.Size = new System.Drawing.Size(260, 388);
            this.MenuPnl.TabIndex = 1;
            // 
            // AddEndPointBttn
            // 
            this.AddEndPointBttn.BackColor = System.Drawing.Color.White;
            this.AddEndPointBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEndPointBttn.Enabled = false;
            this.AddEndPointBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.AddEndPointBttn.FlatAppearance.BorderSize = 3;
            this.AddEndPointBttn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.AddEndPointBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.AddEndPointBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.AddEndPointBttn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEndPointBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.AddEndPointBttn.Location = new System.Drawing.Point(25, 185);
            this.AddEndPointBttn.Margin = new System.Windows.Forms.Padding(25);
            this.AddEndPointBttn.Name = "AddEndPointBttn";
            this.AddEndPointBttn.Size = new System.Drawing.Size(200, 30);
            this.AddEndPointBttn.TabIndex = 1;
            this.AddEndPointBttn.Text = "Service &Endpoints";
            this.AddEndPointBttn.UseVisualStyleBackColor = true;
            // 
            // NewAPIBttn
            // 
            this.NewAPIBttn.BackColor = System.Drawing.Color.White;
            this.NewAPIBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewAPIBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.NewAPIBttn.FlatAppearance.BorderSize = 3;
            this.NewAPIBttn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.NewAPIBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.NewAPIBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.NewAPIBttn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAPIBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.NewAPIBttn.Location = new System.Drawing.Point(25, 105);
            this.NewAPIBttn.Margin = new System.Windows.Forms.Padding(25);
            this.NewAPIBttn.Name = "NewAPIBttn";
            this.NewAPIBttn.Size = new System.Drawing.Size(200, 30);
            this.NewAPIBttn.TabIndex = 2;
            this.NewAPIBttn.Text = "&New API Service";
            this.NewAPIBttn.UseVisualStyleBackColor = true;
            this.NewAPIBttn.Click += new System.EventHandler(this.NewAPIBttn_Click);
            // 
            // LogsBttn
            // 
            this.LogsBttn.BackColor = System.Drawing.Color.White;
            this.LogsBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogsBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.LogsBttn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LogsBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LogsBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.LogsBttn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.LogsBttn.Location = new System.Drawing.Point(25, 265);
            this.LogsBttn.Margin = new System.Windows.Forms.Padding(25);
            this.LogsBttn.Name = "LogsBttn";
            this.LogsBttn.Size = new System.Drawing.Size(200, 30);
            this.LogsBttn.TabIndex = 3;
            this.LogsBttn.Text = "Configuration &Logs";
            this.LogsBttn.UseVisualStyleBackColor = true;
            this.LogsBttn.Click += new System.EventHandler(this.LogsBttn_Click);
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
            this.ServiceGridTbl.Size = new System.Drawing.Size(522, 388);
            this.ServiceGridTbl.TabIndex = 0;
            // 
            // EndpointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BodyWrapperPnl);
            this.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndpointForm";
            this.Text = "API Endpoint Registration";
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
            this.MenuPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer BodyWrapperPnl;
        private System.Windows.Forms.PictureBox BrandPicBx;
        private System.Windows.Forms.SplitContainer MainWrapper;
        private System.Windows.Forms.TableLayoutPanel MenuPnl;
        private System.Windows.Forms.Button AddEndPointBttn;
        private System.Windows.Forms.Button NewAPIBttn;
        private System.Windows.Forms.Button LogsBttn;
        private System.Windows.Forms.DataGridView ServiceGridTbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel EndPtLnk;
        private System.Windows.Forms.LinkLabel ConfigLnk;
    }
}