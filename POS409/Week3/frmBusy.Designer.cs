namespace Week3
{
    partial class frmBusy
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
            this.ucWaitCursor1 = new Week3.ucWaitCursor();
            this.ucMarqueeProgress1 = new Week3.ucMarqueeProgress();
            this.ucRealProgressBar1 = new Week3.ucRealProgressBar();
            this.SuspendLayout();
            // 
            // ucWaitCursor1
            // 
            this.ucWaitCursor1.Location = new System.Drawing.Point(30, 28);
            this.ucWaitCursor1.Name = "ucWaitCursor1";
            this.ucWaitCursor1.Size = new System.Drawing.Size(252, 78);
            this.ucWaitCursor1.TabIndex = 0;
            // 
            // ucMarqueeProgress1
            // 
            this.ucMarqueeProgress1.Location = new System.Drawing.Point(30, 125);
            this.ucMarqueeProgress1.Name = "ucMarqueeProgress1";
            this.ucMarqueeProgress1.Size = new System.Drawing.Size(252, 150);
            this.ucMarqueeProgress1.TabIndex = 1;
            // 
            // ucRealProgressBar1
            // 
            this.ucRealProgressBar1.Location = new System.Drawing.Point(30, 313);
            this.ucRealProgressBar1.Name = "ucRealProgressBar1";
            this.ucRealProgressBar1.Size = new System.Drawing.Size(252, 150);
            this.ucRealProgressBar1.TabIndex = 2;
            // 
            // frmBusy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 489);
            this.Controls.Add(this.ucRealProgressBar1);
            this.Controls.Add(this.ucMarqueeProgress1);
            this.Controls.Add(this.ucWaitCursor1);
            this.Name = "frmBusy";
            this.Text = "Busy Form";
            this.ResumeLayout(false);

        }

        #endregion

        private ucWaitCursor ucWaitCursor1;
        private ucMarqueeProgress ucMarqueeProgress1;
        private ucRealProgressBar ucRealProgressBar1;
    }
}