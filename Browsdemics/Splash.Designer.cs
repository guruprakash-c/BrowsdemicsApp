namespace Browsdemics
{
    partial class SplashFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashFrm));
            this.MainWrapper = new System.Windows.Forms.SplitContainer();
            this.PreloaderImg = new System.Windows.Forms.PictureBox();
            this.BrandPicBx = new System.Windows.Forms.PictureBox();
            this.MenuGrpBx = new System.Windows.Forms.GroupBox();
            this.MediaMgrBttn = new System.Windows.Forms.Button();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.CopyRightLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainWrapper)).BeginInit();
            this.MainWrapper.Panel1.SuspendLayout();
            this.MainWrapper.Panel2.SuspendLayout();
            this.MainWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreloaderImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandPicBx)).BeginInit();
            this.MenuGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWrapper
            // 
            this.MainWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWrapper.Location = new System.Drawing.Point(0, 0);
            this.MainWrapper.Name = "MainWrapper";
            this.MainWrapper.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainWrapper.Panel1
            // 
            this.MainWrapper.Panel1.Controls.Add(this.PreloaderImg);
            this.MainWrapper.Panel1.Controls.Add(this.BrandPicBx);
            // 
            // MainWrapper.Panel2
            // 
            this.MainWrapper.Panel2.Controls.Add(this.MenuGrpBx);
            this.MainWrapper.Size = new System.Drawing.Size(320, 361);
            this.MainWrapper.SplitterDistance = 85;
            this.MainWrapper.TabIndex = 0;
            // 
            // PreloaderImg
            // 
            this.PreloaderImg.BackColor = System.Drawing.Color.Transparent;
            this.PreloaderImg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PreloaderImg.Image = ((System.Drawing.Image)(resources.GetObject("PreloaderImg.Image")));
            this.PreloaderImg.Location = new System.Drawing.Point(0, 69);
            this.PreloaderImg.Name = "PreloaderImg";
            this.PreloaderImg.Size = new System.Drawing.Size(320, 16);
            this.PreloaderImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PreloaderImg.TabIndex = 2;
            this.PreloaderImg.TabStop = false;
            this.PreloaderImg.Visible = false;
            // 
            // BrandPicBx
            // 
            this.BrandPicBx.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrandPicBx.Image = ((System.Drawing.Image)(resources.GetObject("BrandPicBx.Image")));
            this.BrandPicBx.Location = new System.Drawing.Point(0, 0);
            this.BrandPicBx.Name = "BrandPicBx";
            this.BrandPicBx.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.BrandPicBx.Size = new System.Drawing.Size(320, 45);
            this.BrandPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BrandPicBx.TabIndex = 1;
            this.BrandPicBx.TabStop = false;
            // 
            // MenuGrpBx
            // 
            this.MenuGrpBx.Controls.Add(this.CopyRightLbl);
            this.MenuGrpBx.Controls.Add(this.ExitBttn);
            this.MenuGrpBx.Controls.Add(this.MediaMgrBttn);
            this.MenuGrpBx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuGrpBx.Enabled = false;
            this.MenuGrpBx.Location = new System.Drawing.Point(0, 0);
            this.MenuGrpBx.Name = "MenuGrpBx";
            this.MenuGrpBx.Size = new System.Drawing.Size(320, 272);
            this.MenuGrpBx.TabIndex = 0;
            this.MenuGrpBx.TabStop = false;
            this.MenuGrpBx.Text = "Menu";
            // 
            // MediaMgrBttn
            // 
            this.MediaMgrBttn.BackColor = System.Drawing.Color.White;
            this.MediaMgrBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MediaMgrBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.MediaMgrBttn.FlatAppearance.BorderSize = 3;
            this.MediaMgrBttn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.MediaMgrBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.MediaMgrBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.MediaMgrBttn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaMgrBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.MediaMgrBttn.Location = new System.Drawing.Point(9, 41);
            this.MediaMgrBttn.Margin = new System.Windows.Forms.Padding(25);
            this.MediaMgrBttn.Name = "MediaMgrBttn";
            this.MediaMgrBttn.Size = new System.Drawing.Size(300, 30);
            this.MediaMgrBttn.TabIndex = 4;
            this.MediaMgrBttn.Text = "Media  Manager";
            this.MediaMgrBttn.UseVisualStyleBackColor = true;
            this.MediaMgrBttn.Click += new System.EventHandler(this.MediaMgrBttn_Click);
            // 
            // ExitBttn
            // 
            this.ExitBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(90)))), ((int)(((byte)(88)))));
            this.ExitBttn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ExitBttn.FlatAppearance.BorderSize = 3;
            this.ExitBttn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ExitBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ExitBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ExitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBttn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBttn.ForeColor = System.Drawing.Color.White;
            this.ExitBttn.Location = new System.Drawing.Point(9, 194);
            this.ExitBttn.Margin = new System.Windows.Forms.Padding(25);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(300, 30);
            this.ExitBttn.TabIndex = 5;
            this.ExitBttn.Text = "E&xit";
            this.ExitBttn.UseVisualStyleBackColor = false;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // CopyRightLbl
            // 
            this.CopyRightLbl.AutoSize = true;
            this.CopyRightLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightLbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CopyRightLbl.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyRightLbl.ForeColor = System.Drawing.Color.Silver;
            this.CopyRightLbl.Location = new System.Drawing.Point(3, 256);
            this.CopyRightLbl.Name = "CopyRightLbl";
            this.CopyRightLbl.Size = new System.Drawing.Size(47, 13);
            this.CopyRightLbl.TabIndex = 6;
            this.CopyRightLbl.Text = "CopyLbl";
            this.CopyRightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 361);
            this.Controls.Add(this.MainWrapper);
            this.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browsdemics Sync";
            this.Load += new System.EventHandler(this.SplashFrm_Load);
            this.MainWrapper.Panel1.ResumeLayout(false);
            this.MainWrapper.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainWrapper)).EndInit();
            this.MainWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreloaderImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandPicBx)).EndInit();
            this.MenuGrpBx.ResumeLayout(false);
            this.MenuGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainWrapper;
        private System.Windows.Forms.GroupBox MenuGrpBx;
        private System.Windows.Forms.Button MediaMgrBttn;
        private System.Windows.Forms.PictureBox BrandPicBx;
        private System.Windows.Forms.PictureBox PreloaderImg;
        private System.Windows.Forms.Label CopyRightLbl;
        private System.Windows.Forms.Button ExitBttn;
    }
}