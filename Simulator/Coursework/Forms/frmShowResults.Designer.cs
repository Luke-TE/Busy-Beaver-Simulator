namespace Coursework
{
    partial class FrmShowResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowResults));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblFilters = new System.Windows.Forms.Label();
            this.cmbRecurFilter = new System.Windows.Forms.ComboBox();
            this.cmbStateFilter = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnActionImage = new System.Windows.Forms.Button();
            this.btnTapeImage = new System.Windows.Forms.Button();
            this.BeaverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.States = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recurring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NonZeroCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastExecution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
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
            this.NonZeroCount,
            this.StepCount,
            this.LastExecution});
            this.dgvResults.Location = new System.Drawing.Point(0, 90);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvResults.Size = new System.Drawing.Size(864, 407);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvResults_SortCompare);
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Location = new System.Drawing.Point(33, 31);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(34, 13);
            this.lblFilters.TabIndex = 1;
            this.lblFilters.Text = "Show";
            // 
            // cmbRecurFilter
            // 
            this.cmbRecurFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecurFilter.FormattingEnabled = true;
            this.cmbRecurFilter.Items.AddRange(new object[] {
            "Recurring",
            "Non-recurring",
            "Finished",
            "Unfinished"});
            this.cmbRecurFilter.Location = new System.Drawing.Point(201, 28);
            this.cmbRecurFilter.Name = "cmbRecurFilter";
            this.cmbRecurFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbRecurFilter.TabIndex = 3;
            this.cmbRecurFilter.SelectedIndexChanged += new System.EventHandler(this.cmbRecurFilter_SelectedIndexChanged);
            // 
            // cmbStateFilter
            // 
            this.cmbStateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStateFilter.FormattingEnabled = true;
            this.cmbStateFilter.Location = new System.Drawing.Point(74, 28);
            this.cmbStateFilter.Name = "cmbStateFilter";
            this.cmbStateFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbStateFilter.TabIndex = 3;
            this.cmbStateFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStateFilter_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(761, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnActionImage
            // 
            this.btnActionImage.Location = new System.Drawing.Point(509, 26);
            this.btnActionImage.Name = "btnActionImage";
            this.btnActionImage.Size = new System.Drawing.Size(98, 56);
            this.btnActionImage.TabIndex = 20;
            this.btnActionImage.Text = "Show action image for selected beaver";
            this.btnActionImage.UseVisualStyleBackColor = true;
            this.btnActionImage.Click += new System.EventHandler(this.btnActionImage_Click);
            // 
            // btnTapeImage
            // 
            this.btnTapeImage.Location = new System.Drawing.Point(364, 26);
            this.btnTapeImage.Name = "btnTapeImage";
            this.btnTapeImage.Size = new System.Drawing.Size(96, 56);
            this.btnTapeImage.TabIndex = 19;
            this.btnTapeImage.Text = "Show tape image for selected beaver";
            this.btnTapeImage.UseVisualStyleBackColor = true;
            this.btnTapeImage.Click += new System.EventHandler(this.btnTapeImage_Click);
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
            // NonZeroCount
            // 
            this.NonZeroCount.HeaderText = "Number of Non-Zeroes";
            this.NonZeroCount.Name = "NonZeroCount";
            this.NonZeroCount.ReadOnly = true;
            // 
            // StepCount
            // 
            this.StepCount.HeaderText = "Number of Steps";
            this.StepCount.Name = "StepCount";
            this.StepCount.ReadOnly = true;
            // 
            // LastExecution
            // 
            this.LastExecution.HeaderText = "Last Time Executed";
            this.LastExecution.Name = "LastExecution";
            this.LastExecution.ReadOnly = true;
            // 
            // FrmShowResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 499);
            this.Controls.Add(this.btnActionImage);
            this.Controls.Add(this.btnTapeImage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbStateFilter);
            this.Controls.Add(this.cmbRecurFilter);
            this.Controls.Add(this.lblFilters);
            this.Controls.Add(this.dgvResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmShowResults";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmShowResults_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.ComboBox cmbRecurFilter;
        private System.Windows.Forms.ComboBox cmbStateFilter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnActionImage;
        private System.Windows.Forms.Button btnTapeImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeaverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn States;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finished;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recurring;
        private System.Windows.Forms.DataGridViewTextBoxColumn NonZeroCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastExecution;
    }
}