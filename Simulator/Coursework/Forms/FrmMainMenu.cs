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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            //Prevents enlarging of window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.Text = ""; //Window text
            InitializeComponent();
        }

        private void btnCustBeaver_Click(object sender, EventArgs e)
        {
            (new FrmCustomBeaver()).Show();
            this.Close();
                        
        }

        private void btnDataBeaver_Click(object sender, EventArgs e)
        {
            (new FrmDatabaseBeaver()).Show();
            this.Close();
            
            
        }

        private void btnRandBeaver_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            BeaverDBConn dB = new BeaverDBConn("BusyBeaver", "A7951", "KNHWIQ", "10.2.1.26");

            List<State> States;

            do
            {
                States = new List<State>();
                int stateCount = random.Next(2, 6);
                int actionCount = random.Next(2, 6);

                List<char> diffStates = Enumerable.Range(0, stateCount).Select(x => (char)(65 + x)).ToList();
                diffStates.Insert(0, 'h');

                for (int state = 1; state < stateCount + 1; state++)
                {
                    State tempState = new State(diffStates[state], actionCount);

                    for (int action = 0; action < actionCount; action++)
                    {
                        char nextState = diffStates[random.Next(diffStates.Count)];
                        byte newValue = (byte)random.Next(actionCount);
                        bool movement = random.Next(2) == 0;

                        tempState[action] = new Action((byte)action, nextState, newValue, movement);
                    }

                    States.Add(tempState);
                }
            } while (!dB.ValidateStates(States));

            Beaver beaver = new Beaver(States);
            (new FrmExecuteBeaver(beaver, 20, true)).Show();
            this.Close();

            

            
           
            
             
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            (new FrmShowResults()).Show();
            this.Close();
            
            
            
        }

        private void FrmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {            
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
