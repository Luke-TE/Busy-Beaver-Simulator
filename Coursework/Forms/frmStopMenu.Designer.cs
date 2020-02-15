namespace Coursework
{
    partial class FrmStopMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStopMenu));
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMarkRecur = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnActionsImage = new System.Windows.Forms.Button();
            this.btnTapeImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Location = new System.Drawing.Point(66, 51);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(229, 37);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue Running";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(66, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(229, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save and go to main menu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMarkRecur
            // 
            this.btnMarkRecur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkRecur.Location = new System.Drawing.Point(66, 264);
            this.btnMarkRecur.Name = "btnMarkRecur";
            this.btnMarkRecur.Size = new System.Drawing.Size(229, 37);
            this.btnMarkRecur.TabIndex = 0;
            this.btnMarkRecur.Text = "Mark as recurring and go to main menu";
            this.btnMarkRecur.UseVisualStyleBackColor = true;
            this.btnMarkRecur.Click += new System.EventHandler(this.btnMarkRecur_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(106, 25);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(136, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "What would you like to do?";
            // 
            // btnActionsImage
            // 
            this.btnActionsImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActionsImage.Location = new System.Drawing.Point(66, 158);
            this.btnActionsImage.Name = "btnActionsImage";
            this.btnActionsImage.Size = new System.Drawing.Size(229, 37);
            this.btnActionsImage.TabIndex = 3;
            this.btnActionsImage.Text = "Create actions image for Busy Beaver";
            this.btnActionsImage.UseVisualStyleBackColor = true;
            this.btnActionsImage.Click += new System.EventHandler(this.btnActionsImage_Click);
            // 
            // btnTapeImage
            // 
            this.btnTapeImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTapeImage.Location = new System.Drawing.Point(66, 106);
            this.btnTapeImage.Name = "btnTapeImage";
            this.btnTapeImage.Size = new System.Drawing.Size(229, 37);
            this.btnTapeImage.TabIndex = 4;
            this.btnTapeImage.Text = "Create tape image for Busy Beaver";
            this.btnTapeImage.UseVisualStyleBackColor = true;
            this.btnTapeImage.Click += new System.EventHandler(this.btnTapeImage_Click);
            // 
            // FrmStopMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 338);
            this.Controls.Add(this.btnTapeImage);
            this.Controls.Add(this.btnActionsImage);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnMarkRecur);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnContinue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStopMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStopMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMarkRecur;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnActionsImage;
        private System.Windows.Forms.Button btnTapeImage;
    }
}