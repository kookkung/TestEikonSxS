using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEikonSxS
{
    public partial class ImageUI : Form
    {
        public Image image;

        public ImageUI()
        {
            InitializeComponent();
        }

        private void ImageUI_Load(object sender, EventArgs e)
        {
            pictImage.Width = image.Width;
            pictImage.Height = image.Width;
            pictImage.Image = image;

            this.Width = image.Width;
            this.Height = image.Height;

            
           

        }
    }
}
