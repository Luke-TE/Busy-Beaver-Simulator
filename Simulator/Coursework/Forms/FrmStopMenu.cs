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
        private Beaver CurrentBeaver;   

        public FrmStopMenu(Beaver beaver)
        {
            //Prevents enlarging of window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.Text = ""; //Window text
            InitializeComponent();

            this.CurrentBeaver = beaver;
        }

        

        private void OpenMainMenu()
        {
            Application.OpenForms["FrmExecuteBeaver"].Close();
            Application.OpenForms["FrmStopMenu"].Close();
            (new FrmMainMenu()).Show();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            BeaverDBConn dB = new BeaverDBConn("BusyBeaver", "A7951", "KNHWIQ", "10.2.1.26");

            CurrentBeaver.CreateTapeImageRecur();
            CurrentBeaver.CreateActionImageRecur();
            CurrentBeaver.SaveToDB();
            OpenMainMenu();
        }

        private void btnMarkRecur_Click(object sender, EventArgs e)
        {            
            BeaverDBConn dB = new BeaverDBConn("BusyBeaver", "A7951", "KNHWIQ", "10.2.1.26");
            CurrentBeaver.Finished = true;
            CurrentBeaver.Recurring = true;
            CurrentBeaver.CreateTapeImageRecur();
            CurrentBeaver.CreateActionImageRecur();
            CurrentBeaver.SaveToDB();
            OpenMainMenu();
        }

        private void FrmStopMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "FrmPictureMessage")
                    Application.OpenForms[i--].Close();

            CurrentBeaver.ActionImage = null;
            CurrentBeaver.TapeImage = null;

            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void btnTapeImage_Click(object sender, EventArgs e)
        {
            (new FrmPictureMessage(CurrentBeaver.CreateTapeImageRecur())).Show();
        }

        private void btnActionsImage_Click(object sender, EventArgs e)
        {            
            (new FrmPictureMessage(CurrentBeaver.CreateActionImageRecur())).Show();
        }

        

    }
}
