using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class FrmPictureMessage : Form
    {
        public FrmPictureMessage(Bitmap image)
        {
            this.Text = ""; //Window text

            InitializeComponent();
            picTapeChanges.Image = image;
            if (image.Width < SystemInformation.VirtualScreen.Width || image.Height < SystemInformation.VirtualScreen.Height)
                this.Size = image.Size; 
        }

        private void FrmPictureMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
