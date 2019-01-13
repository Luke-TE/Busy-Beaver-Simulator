using System;
namespace Coursework
{
    partial class FrmCustomBeaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomBeaver));
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.nudStates = new System.Windows.Forms.NumericUpDown();
            this.nudSymbols = new System.Windows.Forms.NumericUpDown();
            this.lblStates = new System.Windows.Forms.Label();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trbSpeed = new System.Windows.Forms.TrackBar();
            this.chkDeteRecur = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymbols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContainer.Location = new System.Drawing.Point(0, 103);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(485, 209);
            this.tabContainer.TabIndex = 0;
            // 
            // nudStates
            // 
            this.nudStates.Location = new System.Drawing.Point(116, 12);
            this.nudStates.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStates.Name = "nudStates";
            this.nudStates.Size = new System.Drawing.Size(42, 20);
            this.nudStates.TabIndex = 1;
            this.nudStates.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStates.ValueChanged += new System.EventHandler(this.nudStates_ValueChanged);
            // 
            // nudSymbols
            // 
            this.nudSymbols.Location = new System.Drawing.Point(116, 53);
            this.nudSymbols.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudSymbols.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSymbols.Name = "nudSymbols";
            this.nudSymbols.Size = new System.Drawing.Size(42, 20);
            this.nudSymbols.TabIndex = 2;
            this.nudSymbols.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSymbols.ValueChanged += new System.EventHandler(this.nudSymbols_ValueChanged);
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.Location = new System.Drawing.Point(18, 14);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(92, 13);
            this.lblStates.TabIndex = 3;
            this.lblStates.Text = "Number of States:";
            // 
            // lblSymbols
            // 
            this.lblSymbols.AutoSize = true;
            this.lblSymbols.Location = new System.Drawing.Point(12, 55);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(101, 13);
            this.lblSymbols.TabIndex = 4;
            this.lblSymbols.Text = "Number of Symbols:";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(327, 40);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(120, 43);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute this Beaver";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(180, 51);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "Speed:";
            // 
            // trbSpeed
            // 
            this.trbSpeed.Location = new System.Drawing.Point(227, 51);
            this.trbSpeed.Maximum = 20;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Size = new System.Drawing.Size(94, 45);
            this.trbSpeed.TabIndex = 6;
            this.trbSpeed.Value = 10;
            // 
            // chkDeteRecur
            // 
            this.chkDeteRecur.AutoSize = true;
            this.chkDeteRecur.Location = new System.Drawing.Point(183, 19);
            this.chkDeteRecur.Name = "chkDeteRecur";
            this.chkDeteRecur.Size = new System.Drawing.Size(117, 17);
            this.chkDeteRecur.TabIndex = 15;
            this.chkDeteRecur.Text = "Detect Recurrence";
            this.chkDeteRecur.UseVisualStyleBackColor = true;            
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(349, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCustomBeaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 312);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkDeteRecur);
            this.Controls.Add(this.trbSpeed);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblSymbols);
            this.Controls.Add(this.lblStates);
            this.Controls.Add(this.nudSymbols);
            this.Controls.Add(this.nudStates);
            this.Controls.Add(this.tabContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomBeaver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCustomBeaver_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSymbols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.NumericUpDown nudStates;
        private System.Windows.Forms.NumericUpDown nudSymbols;
        private System.Windows.Forms.Label lblStates;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trbSpeed;
        private System.Windows.Forms.CheckBox chkDeteRecur;
        private System.Windows.Forms.Button btnBack;
    }
}