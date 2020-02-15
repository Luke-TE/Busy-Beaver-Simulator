namespace Coursework
{
    partial class FrmPictureMessage
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
            this.picTapeChanges = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTapeChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // picTapeChanges
            // 
            this.picTapeChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTapeChanges.Location = new System.Drawing.Point(0, 0);
            this.picTapeChanges.Name = "picTapeChanges";
            this.picTapeChanges.Size = new System.Drawing.Size(235, 233);
            this.picTapeChanges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTapeChanges.TabIndex = 0;
            this.picTapeChanges.TabStop = false;
            // 
            // FrmPictureMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 227);
            this.Controls.Add(this.picTapeChanges);
            this.Name = "FrmPictureMessage";
            this.Text = "FrmPictureMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPictureMessage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picTapeChanges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTapeChanges;
    }
}