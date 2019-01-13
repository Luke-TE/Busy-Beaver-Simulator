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
    public partial class FrmDatabaseBeaver : Form
    {
        BeaverDBConn DB;
        int? StateNumQuery = null;        

        public FrmDatabaseBeaver()
        {
            //Prevents enlarging of window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.Text = ""; //Window text
            InitializeComponent();

            DB = new BeaverDBConn("BusyBeaver", "A7951", "KNHWIQ", "10.2.1.26");

            DisplayResults();

            int maxState = dgvResults.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["States"].Value));
            List<string> dropDownContents = Enumerable.Range(1, maxState).Select(x => $"Only {x}-State Beavers").ToList();
            dropDownContents.Insert(0, "All Beavers");
            cmbStateFilter.DataSource = dropDownContents;
        }

        private void DisplayResults()
        {
            dgvResults.Rows.Clear();            
            List<List<string>> results = DB.SelectBeavers(false, StateNumQuery, null, false);
            if (chkShowFini.Checked)
                results.AddRange(DB.SelectBeavers(false, StateNumQuery, true, true));

            foreach (List<string> row in results)
                dgvResults.Rows.Add(row.ToArray());
        }        

        private void btnTapeImage_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvResults.CurrentCell.OwningRow.Cells["BeaverID"].Value);
            Bitmap img = DB.GetImage(id, 0);

            (new FrmPictureMessage(img)).Show();
        }

        private void btnActionImage_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvResults.CurrentCell.OwningRow.Cells["BeaverID"].Value);
            Bitmap img = DB.GetImage(id, 1);

            (new FrmPictureMessage(img)).Show();
        }

        private void btnExeBeaver_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvResults.CurrentCell.OwningRow.Cells["BeaverID"].Value);
            Beaver beaver = DB.SelectBeaver(id);
            (new FrmExecuteBeaver(beaver, trbSpeed.Value, chkDeteRecur.Checked)).Show(); //Autofilled column error?
            this.Close(); 
        }

        private void cmbStateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStateFilter.SelectedIndex == 0)
                StateNumQuery = null;
            else
                StateNumQuery = cmbStateFilter.SelectedIndex;
            DisplayResults();
        }

        private void FrmDatabaseBeaver_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
                if (Application.OpenForms[i].Name == "FrmPictureMessage")
                    Application.OpenForms[i--].Close();

            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new FrmMainMenu()).Show();
            this.Close();
        }

        private void dgvResults_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            string[] numericColumns = { "BeaverID", "States", "NonZeroCount", "StepCount" };
            if (numericColumns.Contains(e.Column.Name))
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }

        private void chkShowFini_CheckedChanged(object sender, EventArgs e)
        {
            DisplayResults();
        }
    }
}
