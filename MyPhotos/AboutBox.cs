using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotos
{
    public partial class AboutBox : Form
    {
        private const int SDI_ICON = 0;
        private const int MDI_iCON = 1;

        public bool IsMdiApplication
        {
            set
            {
                if (value)
                    lblIcon.ImageIndex = MDI_iCON;
                else
                    lblIcon.ImageIndex = SDI_ICON;
            }
        }

        public string AboutText
        {
            get { return lblAboutText.Text; }
            set { lblAboutText.Text = value; }
        }

        public AboutBox()
        {
            InitializeComponent();
        }

        private void lnkWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnWebSite.Visible = !pnWebSite.Visible;
            if (pnWebSite.Visible)
            {
                webBrowser.Url = new Uri("http://www.manleviet.info");
                lnkWebSite.Text = "Click to hide web page";
                Size = new Size(600, 400);

            }
            else
            {
                lnkWebSite.Text = "Click for book's web site";
                Size = new Size(400, 144);
                Text = "About MyPhotos";
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = webBrowser.DocumentTitle;
        }
    }
}
