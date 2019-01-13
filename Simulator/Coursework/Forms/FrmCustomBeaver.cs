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
    public partial class FrmCustomBeaver : Form
    {
        /// <summary>
        /// Form Constructor
        /// </summary>
        public FrmCustomBeaver()
        {
            //Prevents enlarging of window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.Text = ""; //Window text
            InitializeComponent();

            nudStates.Value = 2;
            nudSymbols.Value = 2;           
        }

        /// <summary>
        /// Changes the number of visible tabs
        /// </summary>
        /// <param name="newTabNumber">Indicates what the number of tabs is being set to</param>
        private void ChangeTabNumber(decimal newTabNumber)
        {
            this.SuspendLayout();

            decimal rowNumber = nudSymbols.Value;
            int currentTabNumber = tabContainer.TabCount;            

            //If more tabs need to be added
            if (newTabNumber > currentTabNumber)                            
                //Add new tab each iteration
                for (int tabNum = currentTabNumber; tabNum < newTabNumber; tabNum++ )
                {                    
                    char tabLetter = (char)(65 + tabNum);
                    
                    //Create controls that will be in tab
                    Label lblCurrentValue = new Label() 
                    {
                        Text = "Current Value",
                        Top = 10,
                        Left = 10,
                        AutoSize = true,
                    };         
                    Label lblNextState = new Label()
                    {
                        Text = "Next State",
                        Top = 10,
                        Left = lblCurrentValue.Left + lblCurrentValue.Width + 20,
                        AutoSize = true,
                    };
                    Label lblNewState = new Label()
                    {
                        Text = "New Value",
                        Top = 10,
                        Left = lblNextState.Left + lblNextState.Width + 20,
                        AutoSize = true,
                    };
                    Label lblMovement = new Label()
                    {
                        Text = "Movement",
                        Top = 10,
                        Left = lblNewState.Left + lblNewState.Width + 20,
                        AutoSize = true,
                    };

                    //Create tab and add its controls
                    TabPage newTabPage = new TabPage() { Name = "State" + tabLetter, Text = "State " + tabLetter };
                    newTabPage.Controls.Add(lblCurrentValue);
                    newTabPage.Controls.Add(lblNextState);
                    newTabPage.Controls.Add(lblNewState);
                    newTabPage.Controls.Add(lblMovement);

                    //Add the necessary amount of rows to the tab
                    for (int row = 0; row < rowNumber; row++)
                    {                        
                        Control[] controls = CreateRow(row, rowNumber);                        
                        foreach (Control control in controls)                        
                            newTabPage.Controls.Add(control);
                                                                  
                    }                              
                                        
                    tabContainer.Controls.Add(newTabPage);                   
                }
            
            //If tabs need to be removed
            else if (newTabNumber < currentTabNumber)            
                //Delete last tab each iteration
                for (int tab = 0; tab < currentTabNumber - newTabNumber; tab++)                
                    tabContainer.Controls.RemoveAt(tabContainer.TabCount - 1);                            

            //Refresh all comboboxes of current tabs
            foreach (TabPage tab in tabContainer.Controls)            
                foreach (Control cont in tab.Controls)                
                    if (cont is ComboBox cmbCurrent)
                    {
                        //Create a list of states (characters) starting from 'A' 
                        List<char> comboVals = Enumerable.Range(0, Convert.ToInt32(nudStates.Value)).Select(x => (char)(65 + x)).ToList();
                        comboVals.Insert(0, 'h'); //Add the halt state

                        //If combo box is empty
                        if (cmbCurrent.Items.Count == 0)
                            //Set the combo box source to comboVals
                            cmbCurrent.DataSource = comboVals;

                        //If combo box not empty
                        else
                        {
                            //Maintain current index of the combo box after setting combo box source to comboVals
                            int selectedIndex = cmbCurrent.SelectedIndex;                                                        
                            cmbCurrent.DataSource = comboVals;

                            if (selectedIndex <= tabContainer.TabCount)
                                cmbCurrent.SelectedIndex = selectedIndex;
                        }                            
                    }                 
          
            this.ResumeLayout();            
        }

        /// <summary>
        /// Changes the number of visible rows in each tab
        /// </summary>
        /// <param name="newRowNumber">Indicates what the number of rows is being set to</param>
        private void ChangeRowNumber(decimal newRowNumber)
        {                 
            this.SuspendLayout();
            
            //Gets number of controls in the first tab page
            int currentRowNumber = (tabContainer.Controls[0].Controls.Count - 4) / 4;            

            //iterate through each tab
            foreach (TabPage tab in tabContainer.Controls)
            {

                //If more rows need to be added
                if (newRowNumber > currentRowNumber)                
                    //Add new row for each iteration
                    for (int row = currentRowNumber; row < newRowNumber; row++)
                    {
                        Control[] controls = CreateRow(row, newRowNumber);
                        
                        foreach (Control control in controls)
                            tab.Controls.Add(control);                       
                    }                

                //If rows need to be removed
                else if (newRowNumber < currentRowNumber)                                   
                    //Delete last row each iteration
                    for (int row = 0; row < currentRowNumber - newRowNumber; row++)                    
                        for (int cont = 0; cont < 4; cont++ )                        
                            tab.Controls.RemoveAt(tab.Controls.Count - 1);                                                                                        

                //Update all symbol UpDowns in all tabs
                foreach (Control cont in tab.Controls)                
                    if (cont is NumericUpDown)                   
                        ((NumericUpDown)cont).Maximum = newRowNumber - 1;                                    
            }
            this.ResumeLayout();
        }

        /// <summary>
        /// Return array of controls representing a row
        /// </summary>
        /// <param name="row">Current row</param>
        /// <param name="rowNumber">Final number of rows</param>
        /// <returns></returns>
        public Control[] CreateRow(int row, decimal rowNumber)
        {
            //Create a list of states (characters) starting from 'A' 
            List<char> comboBoxSource = Enumerable.Range(0, Convert.ToInt32(nudStates.Value)).Select(x => (char)(65 + x)).ToList();
            comboBoxSource.Insert(0,'h'); //Add the halt state
            
            return new Control[] {
                new Label() {
                Name = "lblCurrentValNum",
                Text = row.ToString(),
                AutoSize = true,
                Top = 20 * row + 40,
                Left = 40,
            }, 
                new ComboBox()
                {
                    Name = "cmbNextState",
                    Text = "A",
                    Top = 20 * row + 40,
                    Left = 145,
                    Width = 32,
                    DataSource = comboBoxSource,
                    DropDownStyle = ComboBoxStyle.DropDownList,                    
                
                }, 
                new NumericUpDown()
                {
                    Name = "nudNewValue",
                    Top = 20 * row + 40,
                    Left = 265,
                    Minimum = 0,
                    Maximum = rowNumber - 1,
                    Width = 30,
                }, 
                new Panel()
                {          
                    Name = "pnlMovement",
                    Top = 20 * row + 40,
                    Left = 365,
                    Width = 70,
                    Height = 20,
                    Controls =
                    {
                        new RadioButton()
                        {
                            Text = "L",
                            AutoSize = true,
                            Checked = true,
                        },
                        new RadioButton()
                        {
                            Text = "R",
                            Left = 35,
                            AutoSize = true,
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Open and pass beaver to ExecuteBeaver form 
        /// </summary>
        public void StartExecute()
        {                       
            List<State> States = new List<State>();
            int actionCount = (int)nudSymbols.Value;

            //iterate for each state
            foreach (TabPage tab in tabContainer.Controls)
            {                                
                State tempState = new State(tab.Name.Last(), actionCount); //Create temporary State object to hold actions

                //iterate for each action
                for (int rowNum = 1; rowNum <= actionCount; rowNum++)
                {
                    //Declare variables holding the values of the controls
                    char nextState = char.Parse(tab.Controls[rowNum * 4 + 1].Text);
                    byte newValue = (byte)((NumericUpDown)tab.Controls[rowNum * 4 + 2]).Value;
                    bool movement = ((RadioButton)(((Panel)tab.Controls[rowNum * 4 + 3]).Controls[0])).Checked;

                    //Add action to temporary state object
                    tempState[rowNum - 1] = new Action((byte)(rowNum - 1), nextState, newValue, movement);
                }

                //Add state to list of states                
                States.Add(tempState); 
            }

            BeaverDBConn dB = new BeaverDBConn("BusyBeaver", "A7951", "KNHWIQ", "10.2.1.26");
            if (dB.ValidateStates(States))
            {
                Beaver beaver = new Beaver(States);

                //Open ExecuteBeaver form and close this form                  
                (new FrmExecuteBeaver(beaver, trbSpeed.Value, chkDeteRecur.Checked)).Show();
                this.Close();

            }
            else
                MessageBox.Show("Inputted beaver is not valid. \n\n" +
                    "It may be because the beaver:\n" +
                    "-Does not reference a halt state\n" +
                    "-Is already found in the database\n" +
                    "-Has its first action going to itself\n" +
                    "-Has its first action halting");
            
        }

        

        private void btnExecute_Click(object sender, EventArgs e)
        {
            StartExecute();
        }

        private void nudStates_ValueChanged(object sender, EventArgs e)
        {
            ChangeTabNumber(nudStates.Value);
        }

        private void nudSymbols_ValueChanged(object sender, EventArgs e)
        {
            ChangeRowNumber(nudSymbols.Value);
        }

        private void FrmCustomBeaver_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new FrmMainMenu()).Show();
            this.Close();
        }
    }
}
