using EikonSxSClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TestEikonSxS
{
    public partial class ShareAppUI : Form
    {

        public EikonSxS eikon;
        
        public ShareAppUI()
        {
            InitializeComponent();
        }

        private void ShareAppUI_Load(object sender, EventArgs e)
        {
            this.Text = "Share via " + eikon.APPNAME;

            lblTitle.Text = eikon.SHAREAPP.title;
            lnklblURI.Text = eikon.SHAREAPP.appURI;

            // Show Image             
            //Decode Base64 string to Image
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(eikon.SHAREAPP.image);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);

            pictEikonApp.SizeMode = PictureBoxSizeMode.Zoom;
            pictEikonApp.Image = image;

        }

        private void lnklblURI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // IF clicked on link lable,  open the URL
            Process.Start(lnklblURI.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string strMailTo = "";

            strMailTo = string.Format("mailto:{0}?subject={1}&body={1}    Link:{2}", txbMailTo.Text, lblTitle.Text, lnklblURI.Text);

            Process.Start(strMailTo);
        }

        private void txbMailTo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendEmail_Click(sender, e);

            }
        }
    }
}
