namespace MyPhotos
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblAboutText = new System.Windows.Forms.Label();
            this.lnkWebSite = new System.Windows.Forms.LinkLabel();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.pnWebSite = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.pnWebSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "open-book.png");
            this.imageIcons.Images.SetKeyName(1, "photo-camera (1).png");
            // 
            // lblIcon
            // 
            this.lblIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIcon.ImageIndex = 0;
            this.lblIcon.ImageList = this.imageIcons;
            this.lblIcon.Location = new System.Drawing.Point(13, 13);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(43, 42);
            this.lblIcon.TabIndex = 0;
            // 
            // lblAboutText
            // 
            this.lblAboutText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAboutText.Location = new System.Drawing.Point(80, 13);
            this.lblAboutText.Name = "lblAboutText";
            this.lblAboutText.Size = new System.Drawing.Size(292, 42);
            this.lblAboutText.TabIndex = 1;
            this.lblAboutText.Text = "MyPhotos";
            // 
            // lnkWebSite
            // 
            this.lnkWebSite.AutoSize = true;
            this.lnkWebSite.Location = new System.Drawing.Point(10, 64);
            this.lnkWebSite.Name = "lnkWebSite";
            this.lnkWebSite.Size = new System.Drawing.Size(118, 13);
            this.lnkWebSite.TabIndex = 2;
            this.lnkWebSite.TabStop = true;
            this.lnkWebSite.Text = "Click for book\'s website";
            this.lnkWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWebSite_LinkClicked);
            // 
            // lnkClose
            // 
            this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClose.AutoSize = true;
            this.lnkClose.Location = new System.Drawing.Point(266, 64);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(106, 13);
            this.lnkClose.TabIndex = 3;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "Click o close window";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // pnWebSite
            // 
            this.pnWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnWebSite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnWebSite.Controls.Add(this.webBrowser);
            this.pnWebSite.Location = new System.Drawing.Point(15, 80);
            this.pnWebSite.Name = "pnWebSite";
            this.pnWebSite.Size = new System.Drawing.Size(357, 22);
            this.pnWebSite.TabIndex = 4;
            this.pnWebSite.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(353, 20);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 106);
            this.Controls.Add(this.pnWebSite);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.lnkWebSite);
            this.Controls.Add(this.lblAboutText);
            this.Controls.Add(this.lblIcon);
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About MyPhotos";
            this.pnWebSite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblAboutText;
        private System.Windows.Forms.LinkLabel lnkWebSite;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.Panel pnWebSite;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}