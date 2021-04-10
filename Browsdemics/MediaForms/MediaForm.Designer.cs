namespace Browsdemics.MediaForms
{
    partial class MediaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaForm));
            this.BodyWrapperPnl = new System.Windows.Forms.SplitContainer();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BrandPicBx = new System.Windows.Forms.PictureBox();
            this.MediaMenuBar = new System.Windows.Forms.MenuStrip();
            this.MediaFileMnuStrp = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaFileNewMediaMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaFileReloadMediaMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MediaExitMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaEditMnuStrp = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaUpdateMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaBlockMnuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerExecutiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaRegGrpBx = new System.Windows.Forms.GroupBox();
            this.MediaDtlDTblView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BodyWrapperPnl)).BeginInit();
            this.BodyWrapperPnl.Panel1.SuspendLayout();
            this.BodyWrapperPnl.Panel2.SuspendLayout();
            this.BodyWrapperPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrandPicBx)).BeginInit();
            this.MediaMenuBar.SuspendLayout();
            this.MediaRegGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaDtlDTblView)).BeginInit();
            this.SuspendLayout();
            // 
            // BodyWrapperPnl
            // 
            this.BodyWrapperPnl.BackColor = System.Drawing.Color.White;
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
            this.BodyWrapperPnl.Panel1.Controls.Add(this.linkLabel1);
            this.BodyWrapperPnl.Panel1.Controls.Add(this.BrandPicBx);
            this.BodyWrapperPnl.Panel1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BodyWrapperPnl.Panel2
            // 
            this.BodyWrapperPnl.Panel2.Controls.Add(this.MediaMenuBar);
            this.BodyWrapperPnl.Panel2.Controls.Add(this.MediaRegGrpBx);
            this.BodyWrapperPnl.Size = new System.Drawing.Size(800, 450);
            this.BodyWrapperPnl.SplitterDistance = 69;
            this.BodyWrapperPnl.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(179)))));
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(128)))));
            this.linkLabel1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.linkLabel1.Location = new System.Drawing.Point(709, 30);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Media Manager";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(204)))));
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
            // MediaMenuBar
            // 
            this.MediaMenuBar.BackColor = System.Drawing.Color.Transparent;
            this.MediaMenuBar.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MediaFileMnuStrp,
            this.MediaEditMnuStrp,
            this.supportToolStripMenuItem});
            this.MediaMenuBar.Location = new System.Drawing.Point(0, 0);
            this.MediaMenuBar.Name = "MediaMenuBar";
            this.MediaMenuBar.Size = new System.Drawing.Size(800, 24);
            this.MediaMenuBar.TabIndex = 14;
            this.MediaMenuBar.Text = "menuStrip1";
            // 
            // MediaFileMnuStrp
            // 
            this.MediaFileMnuStrp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MediaFileNewMediaMnuItm,
            this.MediaFileReloadMediaMnuItm,
            this.toolStripSeparator1,
            this.MediaExitMnuItm});
            this.MediaFileMnuStrp.Name = "MediaFileMnuStrp";
            this.MediaFileMnuStrp.Size = new System.Drawing.Size(38, 20);
            this.MediaFileMnuStrp.Text = "&File";
            // 
            // MediaFileNewMediaMnuItm
            // 
            this.MediaFileNewMediaMnuItm.Name = "MediaFileNewMediaMnuItm";
            this.MediaFileNewMediaMnuItm.Size = new System.Drawing.Size(147, 22);
            this.MediaFileNewMediaMnuItm.Text = "&New Media";
            this.MediaFileNewMediaMnuItm.Click += new System.EventHandler(this.MediaFileNewMediaMnuItm_Click);
            // 
            // MediaFileReloadMediaMnuItm
            // 
            this.MediaFileReloadMediaMnuItm.Name = "MediaFileReloadMediaMnuItm";
            this.MediaFileReloadMediaMnuItm.Size = new System.Drawing.Size(147, 22);
            this.MediaFileReloadMediaMnuItm.Text = "&Reload Media";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // MediaExitMnuItm
            // 
            this.MediaExitMnuItm.Name = "MediaExitMnuItm";
            this.MediaExitMnuItm.Size = new System.Drawing.Size(147, 22);
            this.MediaExitMnuItm.Text = "E&xit";
            this.MediaExitMnuItm.Click += new System.EventHandler(this.MediaExitMnuItm_Click);
            // 
            // MediaEditMnuStrp
            // 
            this.MediaEditMnuStrp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MediaUpdateMnuItm,
            this.MediaBlockMnuItm});
            this.MediaEditMnuStrp.Name = "MediaEditMnuStrp";
            this.MediaEditMnuStrp.Size = new System.Drawing.Size(40, 20);
            this.MediaEditMnuStrp.Text = "&Edit";
            // 
            // MediaUpdateMnuItm
            // 
            this.MediaUpdateMnuItm.Name = "MediaUpdateMnuItm";
            this.MediaUpdateMnuItm.Size = new System.Drawing.Size(149, 22);
            this.MediaUpdateMnuItm.Text = "&Update Media";
            // 
            // MediaBlockMnuItm
            // 
            this.MediaBlockMnuItm.Name = "MediaBlockMnuItm";
            this.MediaBlockMnuItm.Size = new System.Drawing.Size(149, 22);
            this.MediaBlockMnuItm.Text = "&Block Media";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendEmailToolStripMenuItem});
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.supportToolStripMenuItem.Text = "&Support";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.customerExecutiveToolStripMenuItem});
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sendEmailToolStripMenuItem.Text = "Send E&mail";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.administratorToolStripMenuItem.Text = "&Administrator";
            // 
            // customerExecutiveToolStripMenuItem
            // 
            this.customerExecutiveToolStripMenuItem.Name = "customerExecutiveToolStripMenuItem";
            this.customerExecutiveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.customerExecutiveToolStripMenuItem.Text = "&Customer Executive";
            // 
            // MediaRegGrpBx
            // 
            this.MediaRegGrpBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaRegGrpBx.Controls.Add(this.MediaDtlDTblView);
            this.MediaRegGrpBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediaRegGrpBx.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaRegGrpBx.Location = new System.Drawing.Point(0, 27);
            this.MediaRegGrpBx.Name = "MediaRegGrpBx";
            this.MediaRegGrpBx.Size = new System.Drawing.Size(800, 350);
            this.MediaRegGrpBx.TabIndex = 1;
            this.MediaRegGrpBx.TabStop = false;
            this.MediaRegGrpBx.Text = "Media Details";
            // 
            // MediaDtlDTblView
            // 
            this.MediaDtlDTblView.AllowUserToAddRows = false;
            this.MediaDtlDTblView.AllowUserToDeleteRows = false;
            this.MediaDtlDTblView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MediaDtlDTblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaDtlDTblView.Location = new System.Drawing.Point(3, 18);
            this.MediaDtlDTblView.Name = "MediaDtlDTblView";
            this.MediaDtlDTblView.ReadOnly = true;
            this.MediaDtlDTblView.Size = new System.Drawing.Size(794, 329);
            this.MediaDtlDTblView.TabIndex = 0;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyWrapperPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MediaForm_FormClosed);
            this.BodyWrapperPnl.Panel1.ResumeLayout(false);
            this.BodyWrapperPnl.Panel1.PerformLayout();
            this.BodyWrapperPnl.Panel2.ResumeLayout(false);
            this.BodyWrapperPnl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BodyWrapperPnl)).EndInit();
            this.BodyWrapperPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BrandPicBx)).EndInit();
            this.MediaMenuBar.ResumeLayout(false);
            this.MediaMenuBar.PerformLayout();
            this.MediaRegGrpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaDtlDTblView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer BodyWrapperPnl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox BrandPicBx;
        private System.Windows.Forms.GroupBox MediaRegGrpBx;
        private System.Windows.Forms.MenuStrip MediaMenuBar;
        private System.Windows.Forms.ToolStripMenuItem MediaFileMnuStrp;
        private System.Windows.Forms.ToolStripMenuItem MediaEditMnuStrp;
        private System.Windows.Forms.DataGridView MediaDtlDTblView;
        private System.Windows.Forms.ToolStripMenuItem MediaFileNewMediaMnuItm;
        private System.Windows.Forms.ToolStripMenuItem MediaExitMnuItm;
        private System.Windows.Forms.ToolStripMenuItem MediaUpdateMnuItm;
        private System.Windows.Forms.ToolStripMenuItem MediaBlockMnuItm;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerExecutiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MediaFileReloadMediaMnuItm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}