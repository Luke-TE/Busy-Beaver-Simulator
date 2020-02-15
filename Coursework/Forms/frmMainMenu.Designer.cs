namespace Coursework
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btnCustBeaver = new System.Windows.Forms.Button();
            this.btnDataBeaver = new System.Windows.Forms.Button();
            this.btnRandBeaver = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustBeaver
            // 
            this.btnCustBeaver.Location = new System.Drawing.Point(63, 35);
            this.btnCustBeaver.Name = "btnCustBeaver";
            this.btnCustBeaver.Size = new System.Drawing.Size(266, 38);
            this.btnCustBeaver.TabIndex = 0;
            this.btnCustBeaver.Text = "Execute a Custom Beaver";
            this.btnCustBeaver.UseVisualStyleBackColor = true;
            this.btnCustBeaver.Click += new System.EventHandler(this.btnCustBeaver_Click);
            // 
            // btnDataBeaver
            // 
            this.btnDataBeaver.Location = new System.Drawing.Point(63, 90);
            this.btnDataBeaver.Name = "btnDataBeaver";
            this.btnDataBeaver.Size = new System.Drawing.Size(266, 38);
            this.btnDataBeaver.TabIndex = 0;
            this.btnDataBeaver.Text = "Execute a Busy Beaver from the Database";
            this.btnDataBeaver.UseVisualStyleBackColor = true;
            this.btnDataBeaver.Click += new System.EventHandler(this.btnDataBeaver_Click);
            // 
            // btnRandBeaver
            // 
            this.btnRandBeaver.Location = new System.Drawing.Point(63, 146);
            this.btnRandBeaver.Name = "btnRandBeaver";
            this.btnRandBeaver.Size = new System.Drawing.Size(266, 38);
            this.btnRandBeaver.TabIndex = 0;
            this.btnRandBeaver.Text = "Execute a Random Busy Beaver";
            this.btnRandBeaver.UseVisualStyleBackColor = true;
            this.btnRandBeaver.Click += new System.EventHandler(this.btnRandBeaver_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(63, 204);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(266, 38);
            this.btnResults.TabIndex = 0;
            this.btnResults.Text = "Show Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 280);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnRandBeaver);
            this.Controls.Add(this.btnDataBeaver);
            this.Controls.Add(this.btnCustBeaver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustBeaver;
        private System.Windows.Forms.Button btnDataBeaver;
        private System.Windows.Forms.Button btnRandBeaver;
        private System.Windows.Forms.Button btnResults;
    }
}

