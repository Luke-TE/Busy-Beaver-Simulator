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
    public partial class FrmStopMenu : Form
    {
        private List<List<int>> TapeRecords;
        private int nonZeroCount;
        private int stepCount;


        public FrmStopMenu()
        {
            //Prevents enlarging of window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.Text = ""; //Window text
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            Bitmap tapeChanges = BeaverImage.CreateTapeImage(TapeRecords, 50);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap tapeChanges = BeaverImage.CreateTapeImage(TapeRecords, 50);
            DBConn dB = new DBConn("BusyBeaver", "A7951", "KNHWIQ", "10.2.1.26");
            //dB.InsertBeaver(tapeString, true, false, finalNonZeroCount, finalStepCount, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), tapeChanges, States);
        }

        private void btnMarkRecur_Click(object sender, EventArgs e)
        {

        }

        private void FrmStopMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
