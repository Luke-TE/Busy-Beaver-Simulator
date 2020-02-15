namespace Coursework
{
    partial class FrmDatabaseBeaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabaseBeaver));
            this.chkShowFini = new System.Windows.Forms.CheckBox();
            this.cmbStateFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnTapeImage = new System.Windows.Forms.Button();
            this.btnExeBeaver = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnActionImage = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.BeaverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.States = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recurring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastExecution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDeteRecur = new System.Windows.Forms.CheckBox();
            this.trbSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // chkShowFini
            // 
            this.chkShowFini.AutoSize = true;
            this.chkShowFini.Location = new System.Drawing.Point(23, 55);
            this.chkShowFini.Name = "chkShowFini";
            this.chkShowFini.Size = new System.Drawing.Size(138, 17);
            this.chkShowFini.TabIndex = 2;
            this.chkShowFini.Text = "Show recurring beavers";
            this.chkShowFini.UseVisualStyleBackColor = true;
            this.chkShowFini.CheckedChanged += new System.EventHandler(this.chkShowFini_CheckedChanged);
            // 
            // cmbStateFilter
            // 
            this.cmbStateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStateFilter.FormattingEnabled = true;
            this.cmbStateFilter.Location = new System.Drawing.Point(63, 15);
            this.cmbStateFilter.Name = "cmbStateFilter";
            this.cmbStateFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbStateFilter.TabIndex = 3;
            this.cmbStateFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStateFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(20, 22);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(34, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Show";
            // 
            // btnTapeImage
            // 
            this.btnTapeImage.Location = new System.Drawing.Point(208, 22);
            this.btnTapeImage.Name = "btnTapeImage";
            this.btnTapeImage.Size = new System.Drawing.Size(96, 56);
            this.btnTapeImage.TabIndex = 5;
            this.btnTapeImage.Text = "Show tape image for selected beaver";
            this.btnTapeImage.UseVisualStyleBackColor = true;
            this.btnTapeImage.Click += new System.EventHandler(this.btnTapeImage_Click);
            // 
            // btnExeBeaver
            // 
            this.btnExeBeaver.Location = new System.Drawing.Point(451, 22);
            this.btnExeBeaver.Name = "btnExeBeaver";
            this.btnExeBeaver.Size = new System.Drawing.Size(101, 56);
            this.btnExeBeaver.TabIndex = 5;
            this.btnExeBeaver.Text = "Execute selected beaver";
            this.btnExeBeaver.UseVisualStyleBackColor = true;
            this.btnExeBeaver.Click += new System.EventHandler(this.btnExeBeaver_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(696, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnActionImage
            // 
            this.btnActionImage.Location = new System.Drawing.Point(320, 22);
            this.btnActionImage.Name = "btnActionImage";
            this.btnActionImage.Size = new System.Drawing.Size(98, 56);
            this.btnActionImage.TabIndex = 18;
            this.btnActionImage.Text = "Show action image for selected beaver";
            this.btnActionImage.UseVisualStyleBackColor = true;
            this.btnActionImage.Click += new System.EventHandler(this.btnActionImage_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BeaverID,
            this.States,
            this.Finished,
            this.Recurring,
            this.LastExecution});
            this.dgvResults.Location = new System.Drawing.Point(-1, 101);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvResults.Size = new System.Drawing.Size(785, 236);
            this.dgvResults.TabIndex = 19;
            this.dgvResults.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvResults_SortCompare);
            // 
            // BeaverID
            // 
            this.BeaverID.HeaderText = "Beaver ID";
            this.BeaverID.Name = "BeaverID";
            this.BeaverID.ReadOnly = true;
            // 
            // States
            // 
            this.States.HeaderText = "Number Of States";
            this.States.Name = "States";
            this.States.ReadOnly = true;
            // 
            // Finished
            // 
            this.Finished.HeaderText = "Finished";
            this.Finished.Name = "Finished";
            this.Finished.ReadOnly = true;
            // 
            // Recurring
            // 
            this.Recurring.HeaderText = "Recurring";
            this.Recurring.Name = "Recurring";
            this.Recurring.ReadOnly = true;
            // 
            // LastExecution
            // 
            this.LastExecution.HeaderText = "Last Time Executed";
            this.LastExecution.Name = "LastExecution";
            this.LastExecution.ReadOnly = true;
            // 
            // chkDeteRecur
            // 
            this.chkDeteRecur.AutoSize = true;
            this.chkDeteRecur.Location = new System.Drawing.Point(561, 23);
            this.chkDeteRecur.Name = "chkDeteRecur";
            this.chkDeteRecur.Size = new System.Drawing.Size(117, 17);
            this.chkDeteRecur.TabIndex = 22;
            this.chkDeteRecur.Text = "Detect Recurrence";
            this.chkDeteRecur.UseVisualStyleBackColor = true;
            // 
            // trbSpeed
            // 
            this.trbSpeed.Location = new System.Drawing.Point(596, 46);
            this.trbSpeed.Maximum = 20;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Size = new System.Drawing.Size(94, 45);
            this.trbSpeed.TabIndex = 21;
            this.trbSpeed.Value = 10;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(558, 55);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 20;
            this.lblSpeed.Text = "Speed:";
            // 
            // FrmDatabaseBeaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 332);
            this.Controls.Add(this.chkDeteRecur);
            this.Controls.Add(this.trbSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnActionImage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExeBeaver);
            this.Controls.Add(this.btnTapeImage);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbStateFilter);
            this.Controls.Add(this.chkShowFini);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDatabaseBeaver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDatabaseBeaver_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStateFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnTapeImage;
        private System.Windows.Forms.Button btnExeBeaver;
        private System.Windows.Forms.CheckBox chkShowFini;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnActionImage;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeaverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn States;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finished;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recurring;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastExecution;
        private System.Windows.Forms.CheckBox chkDeteRecur;
        private System.Windows.Forms.TrackBar trbSpeed;
        private System.Windows.Forms.Label lblSpeed;
    }
}