using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Coursework
{
    public partial class FrmExecuteBeaver : Form
    {
        private const int TAPE_LENGTH = 101;
        private delegate void UpdateUIDelegate(int dataGridRow, Beaver beaver);                        
        private Thread ExecutionThread;
        private Beaver CurrentBeaver;        
        private bool Paused = false;
        private bool CheckRecur;
        private int Speed;
        private int Sample;
        private int SampleSize;


        public FrmExecuteBeaver(Beaver beaver, int speed, bool checkRecur, int sampleSize = 5000)
        {
            //Prevents enlarging of window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.Text = ""; //Window text
            InitializeComponent();

            CurrentBeaver = beaver;            
            SampleSize = sampleSize;
            trbSpeed.Value = Speed = speed;
            chkDeteRecur.Checked = CheckRecur = checkRecur;            

            SetupDataGridView();            
        }

        private void FrmExecuteBeaver_Load(object sender, EventArgs e)
        {
            ExecutionThread = new Thread(new ThreadStart(() => ExecuteBeaver()))
            {
                Name = "Beaver Executor",
                IsBackground = true
            };
            ExecutionThread.Start();
        }

        public void ExecuteBeaver()
        {
            while (CurrentBeaver.CurrentState != null)
            {
                int dgvRowIndex = CurrentBeaver.ExecuteStep();

                try
                {
                    if (Paused) Thread.Sleep(Timeout.Infinite);

                    int delay = 300 - Speed * 15;
                    Thread.Sleep(delay);
                    
                }
                catch (ThreadInterruptedException Error)
                {
                    Console.WriteLine(Error.Message);
                }


                if (CheckRecur)
                {
                    Sample++;                    
                    if (Sample == SampleSize)
                    {
                        SuffixTree SuffixTree = new SuffixTree(CurrentBeaver.ActionRecords);
                        if (SuffixTree.CheckIfRecurring())
                        {
                            MessageBox.Show("The recursion detector has detected possible recursion. \n" +
                            "It is suggested to mark the current beaver as recurring");

                            Sample = 0;
                            Invoke((MethodInvoker)delegate { ShowStopMenu(); });                            
                        }
                    
                    }
                }
                
                UpdateUI(dgvRowIndex, CurrentBeaver);
                
            }
           
            CurrentBeaver.NonZeroCount = CurrentBeaver.Tape.Count(x => x != 0);
            CurrentBeaver.Finished = true;
            CurrentBeaver.HeadPos = null;            
            CurrentBeaver.SaveToDB();


            MessageBox.Show($"Busy Beaver Finished Executing! \n" +
                $"Number of Steps: {CurrentBeaver.StepCount} \n" +
                $"Number of Non-zeroes: {CurrentBeaver.NonZeroCount}");
                        
            Invoke((MethodInvoker) delegate
            {
                (new FrmMainMenu()).Show();
                Close();
            });

            Thread.CurrentThread.Abort();
        }


        public void SetupDataGridView()
        {
            foreach (State state in CurrentBeaver.States)
                foreach (Action action in state.Actions)
                {
                    string currentValue = Array.IndexOf(state.Actions, action).ToString();
                    string nextState = action.NextState.ToString();
                    string newValue = action.NewValue.ToString();
                    string movement = action.Movement.ToString();
                    

                    dgvStates.Rows.Add(new string[] { state.ToString(), currentValue, nextState, newValue, movement });
                }

        }

        public void UpdateUI(int dataGridRow, Beaver beaver)
        {
            if (dgvStates.InvokeRequired || lblTape.InvokeRequired || lblSteps.InvokeRequired)
            {
                UpdateUIDelegate del = new UpdateUIDelegate(UpdateUI);
                Invoke(del, new object[] { dataGridRow, beaver});
            }
            else
            {
                dgvStates.ClearSelection();
                dgvStates.Rows[dataGridRow].Selected = true;

                int headPos = (int)CurrentBeaver.HeadPos;
                int leftOffset = Math.Max(0, (TAPE_LENGTH / 2) - headPos);
                int rightOffset = Math.Max(0, (TAPE_LENGTH / 2) + headPos + 1 - CurrentBeaver.Tape.Count);
                int cellsSkipped = Math.Max(0, headPos - (TAPE_LENGTH / 2));
                int cellsTaken = TAPE_LENGTH - leftOffset - rightOffset;

                lblTape.Text =
                    new string(' ', leftOffset) +
                    string.Join("", CurrentBeaver.Tape.Skip(cellsSkipped).Take(cellsTaken).ToArray()) +
                    new string(' ', rightOffset);
                
                lblSteps.Text = "Steps: " + CurrentBeaver.StepCount.ToString();
            }
                
        }        
        
        

        private void NextStep()
        {
            if (Paused) ExecutionThread.Interrupt();
        }

        private void PauseBeaver()
        {
            if (Paused) ExecutionThread.Interrupt();
            Paused = !Paused;
            lblSingleStep.Enabled = !lblSingleStep.Enabled;
        }

        private void ShowStopMenu()
        {            
            Paused = true;

            this.Hide();
            (new FrmStopMenu(CurrentBeaver)).ShowDialog();
            if (!this.IsDisposed) this.Show();                        
            
            Paused = false;

        }
        


        private void FrmExecuteBeaver_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    PauseBeaver();
                    break;
                case Keys.A:                
                    chkShowAnim.Checked = !chkShowAnim.Checked;
                    break;
                case Keys.S:                
                    chkShowStates.Checked = !chkShowStates.Checked;
                    break;
                case Keys.N:                
                    NextStep();
                    break;
                case Keys.Escape:
                    ShowStopMenu();
                    break;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseBeaver();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {            
            ShowStopMenu();
        }        

        private void FrmExecuteBeaver_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExecutionThread.Abort();
            if (Application.OpenForms.Count == 0) Application.Exit();
        }

        private void trbSpeed_ValueChanged(object sender, EventArgs e)
        {
            Speed = trbSpeed.Value;
        }

        private void chkShowStates_CheckedChanged(object sender, EventArgs e)
        {
            dgvStates.Visible = chkShowStates.Checked;
        }

        private void chkShowAnim_CheckedChanged(object sender, EventArgs e)
        {
            lblTape.Visible = chkShowAnim.Checked;
        }

        private void chkDeteRecur_CheckedChanged(object sender, EventArgs e)
        {
            CheckRecur = chkDeteRecur.Checked;
        }

        
    }
}
;

