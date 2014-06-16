namespace Week3
{
    partial class ucMarqueeProgress
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxMarquee = new System.Windows.Forms.GroupBox();
            this.lblButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nupdwnMarquee = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnProgress = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorkerMarquee = new System.ComponentModel.BackgroundWorker();
            this.progressBarMarquee = new System.Windows.Forms.ProgressBar();
            this.statusStripMarquee = new System.Windows.Forms.StatusStrip();
            this.gbxMarquee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnMarquee)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMarquee
            // 
            this.gbxMarquee.Controls.Add(this.label10);
            this.gbxMarquee.Controls.Add(this.nupdwnMarquee);
            this.gbxMarquee.Controls.Add(this.label11);
            this.gbxMarquee.Controls.Add(this.btnProgress);
            this.gbxMarquee.Controls.Add(this.label9);
            this.gbxMarquee.Controls.Add(this.lblButton);
            this.gbxMarquee.Controls.Add(this.label1);
            this.gbxMarquee.Controls.Add(this.btnStop);
            this.gbxMarquee.Controls.Add(this.btnStart);
            this.gbxMarquee.Location = new System.Drawing.Point(13, 4);
            this.gbxMarquee.Name = "gbxMarquee";
            this.gbxMarquee.Size = new System.Drawing.Size(228, 206);
            this.gbxMarquee.TabIndex = 0;
            this.gbxMarquee.TabStop = false;
            this.gbxMarquee.Text = "Marquee Progress Bar";
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblButton.Location = new System.Drawing.Point(6, 16);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(115, 15);
            this.lblButton.TabIndex = 17;
            this.lblButton.Text = "Using Buttons (works):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "then";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(80, 32);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(42, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "seconds";
            // 
            // nupdwnMarquee
            // 
            this.nupdwnMarquee.Location = new System.Drawing.Point(92, 87);
            this.nupdwnMarquee.Name = "nupdwnMarquee";
            this.nupdwnMarquee.Size = new System.Drawing.Size(42, 20);
            this.nupdwnMarquee.TabIndex = 24;
            this.nupdwnMarquee.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "for";
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(3, 86);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(61, 23);
            this.btnProgress.TabIndex = 22;
            this.btnProgress.Text = "Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(0, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Using BackGround Worker Process (works):";
            // 
            // backgroundWorkerMarquee
            // 
            this.backgroundWorkerMarquee.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMarquee_DoWork);
            this.backgroundWorkerMarquee.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMarquee_RunWorkerCompleted);
            // 
            // progressBarMarquee
            // 
            this.progressBarMarquee.Location = new System.Drawing.Point(13, 133);
            this.progressBarMarquee.Name = "progressBarMarquee";
            this.progressBarMarquee.Size = new System.Drawing.Size(162, 16);
            this.progressBarMarquee.TabIndex = 2;
            // 
            // statusStripMarquee
            // 
            this.statusStripMarquee.Location = new System.Drawing.Point(0, 128);
            this.statusStripMarquee.Name = "statusStripMarquee";
            this.statusStripMarquee.Size = new System.Drawing.Size(252, 22);
            this.statusStripMarquee.TabIndex = 1;
            this.statusStripMarquee.Text = "statusStrip1";
            // 
            // ucMarqueeProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBarMarquee);
            this.Controls.Add(this.statusStripMarquee);
            this.Controls.Add(this.gbxMarquee);
            this.Name = "ucMarqueeProgress";
            this.Size = new System.Drawing.Size(252, 150);
            this.gbxMarquee.ResumeLayout(false);
            this.gbxMarquee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwnMarquee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMarquee;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nupdwnMarquee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMarquee;
        private System.Windows.Forms.ProgressBar progressBarMarquee;
        private System.Windows.Forms.StatusStrip statusStripMarquee;
    }
}
