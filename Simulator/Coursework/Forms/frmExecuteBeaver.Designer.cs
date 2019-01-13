namespace Coursework
{
    partial class FrmExecuteBeaver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExecuteBeaver));
            this.dgvStates = new System.Windows.Forms.DataGridView();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.trbSpeed = new System.Windows.Forms.TrackBar();
            this.lblSingleStep = new System.Windows.Forms.Label();
            this.lblTape = new System.Windows.Forms.Label();
            this.chkDeteRecur = new System.Windows.Forms.CheckBox();
            this.chkShowAnim = new System.Windows.Forms.CheckBox();
            this.chkShowStates = new System.Windows.Forms.CheckBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.sfvImage = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStates
            // 
            this.dgvStates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.State,
            this.Value,
            this.NextState,
            this.NewValue,
            this.MoveDirection});
            this.dgvStates.Location = new System.Drawing.Point(444, 23);
            this.dgvStates.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.dgvStates.Name = "dgvStates";
            this.dgvStates.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvStates.Size = new System.Drawing.Size(397, 266);
            this.dgvStates.TabIndex = 1;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // NextState
            // 
            this.NextState.HeaderText = "Next State";
            this.NextState.Name = "NextState";
            this.NextState.ReadOnly = true;
            // 
            // NewValue
            // 
            this.NewValue.HeaderText = "New Value";
            this.NewValue.Name = "NewValue";
            this.NewValue.ReadOnly = true;
            // 
            // MoveDirection
            // 
            this.MoveDirection.HeaderText = "Move Direction";
            this.MoveDirection.Name = "MoveDirection";
            this.MoveDirection.ReadOnly = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(245, 23);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(106, 34);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause Execution (P)";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(245, 86);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 35);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Execution (Esc)";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trbSpeed
            // 
            this.trbSpeed.Location = new System.Drawing.Point(82, 196);
            this.trbSpeed.Maximum = 20;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Size = new System.Drawing.Size(104, 45);
            this.trbSpeed.TabIndex = 4;
            this.trbSpeed.Value = 10;
            this.trbSpeed.ValueChanged += new System.EventHandler(this.trbSpeed_ValueChanged);
            // 
            // lblSingleStep
            // 
            this.lblSingleStep.AutoSize = true;
            this.lblSingleStep.Enabled = false;
            this.lblSingleStep.Location = new System.Drawing.Point(51, 173);
            this.lblSingleStep.Name = "lblSingleStep";
            this.lblSingleStep.Size = new System.Drawing.Size(135, 13);
            this.lblSingleStep.TabIndex = 11;
            this.lblSingleStep.Text = "Press (N) to move one step";
            // 
            // lblTape
            // 
            this.lblTape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTape.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTape.Location = new System.Drawing.Point(12, 312);
            this.lblTape.Margin = new System.Windows.Forms.Padding(3, 0, 20, 20);
            this.lblTape.Name = "lblTape";
            this.lblTape.Size = new System.Drawing.Size(829, 27);
            this.lblTape.TabIndex = 12;
            this.lblTape.Text = "Error has occurred";
            this.lblTape.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkDeteRecur
            // 
            this.chkDeteRecur.AutoSize = true;
            this.chkDeteRecur.Location = new System.Drawing.Point(33, 89);
            this.chkDeteRecur.Name = "chkDeteRecur";
            this.chkDeteRecur.Size = new System.Drawing.Size(134, 17);
            this.chkDeteRecur.TabIndex = 14;
            this.chkDeteRecur.Text = "Detect Recurrence (D)";
            this.chkDeteRecur.UseVisualStyleBackColor = true;
            this.chkDeteRecur.CheckedChanged += new System.EventHandler(this.chkDeteRecur_CheckedChanged);
            // 
            // chkShowAnim
            // 
            this.chkShowAnim.AutoSize = true;
            this.chkShowAnim.Checked = true;
            this.chkShowAnim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAnim.Location = new System.Drawing.Point(33, 55);
            this.chkShowAnim.Name = "chkShowAnim";
            this.chkShowAnim.Size = new System.Drawing.Size(113, 17);
            this.chkShowAnim.TabIndex = 15;
            this.chkShowAnim.Text = "Show Animator (A)";
            this.chkShowAnim.UseVisualStyleBackColor = true;
            this.chkShowAnim.CheckedChanged += new System.EventHandler(this.chkShowAnim_CheckedChanged);
            // 
            // chkShowStates
            // 
            this.chkShowStates.AutoSize = true;
            this.chkShowStates.Checked = true;
            this.chkShowStates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowStates.Location = new System.Drawing.Point(33, 23);
            this.chkShowStates.Name = "chkShowStates";
            this.chkShowStates.Size = new System.Drawing.Size(102, 17);
            this.chkShowStates.TabIndex = 16;
            this.chkShowStates.Text = "Show States (S)";
            this.chkShowStates.UseVisualStyleBackColor = true;
            this.chkShowStates.CheckedChanged += new System.EventHandler(this.chkShowStates_CheckedChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(34, 202);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 17;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(254, 196);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(40, 13);
            this.lblSteps.TabIndex = 18;
            this.lblSteps.Text = "Steps: ";
            // 
            // FrmExecuteBeaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(853, 359);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.chkShowStates);
            this.Controls.Add(this.chkShowAnim);
            this.Controls.Add(this.chkDeteRecur);
            this.Controls.Add(this.lblTape);
            this.Controls.Add(this.lblSingleStep);
            this.Controls.Add(this.trbSpeed);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.dgvStates);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmExecuteBeaver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmExecuteBeaver_FormClosed);
            this.Load += new System.EventHandler(this.FrmExecuteBeaver_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmExecuteBeaver_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStates;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar trbSpeed;
        private System.Windows.Forms.Label lblSingleStep;
        private System.Windows.Forms.Label lblTape;
        private System.Windows.Forms.CheckBox chkDeteRecur;
        private System.Windows.Forms.CheckBox chkShowAnim;
        private System.Windows.Forms.CheckBox chkShowStates;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextState;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveDirection;
        private System.Windows.Forms.SaveFileDialog sfvImage;
    }
}