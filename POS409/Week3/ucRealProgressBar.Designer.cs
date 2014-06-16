namespace Week3
{
    partial class ucRealProgressBar
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
            this.gbxReal = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nupdownTimeSec = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nupdownReal = new System.Windows.Forms.NumericUpDown();
            this.btnDoReal = new System.Windows.Forms.Button();
            this.statusStripReal = new System.Windows.Forms.StatusStrip();
            this.progressBarReal = new System.Windows.Forms.ProgressBar();
            this.gbxReal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownTimeSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownReal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxReal
            // 
            this.gbxReal.Controls.Add(this.label6);
            this.gbxReal.Controls.Add(this.nupdownTimeSec);
            this.gbxReal.Controls.Add(this.label7);
            this.gbxReal.Controls.Add(this.label8);
            this.gbxReal.Controls.Add(this.nupdownReal);
            this.gbxReal.Controls.Add(this.btnDoReal);
            this.gbxReal.Location = new System.Drawing.Point(4, 4);
            this.gbxReal.Name = "gbxReal";
            this.gbxReal.Size = new System.Drawing.Size(244, 100);
            this.gbxReal.TabIndex = 0;
            this.gbxReal.TabStop = false;
            this.gbxReal.Text = "Real Progress Bar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "milli-seconds.";
            // 
            // nupdownTimeSec
            // 
            this.nupdownTimeSec.Location = new System.Drawing.Point(101, 64);
            this.nupdownTimeSec.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupdownTimeSec.Name = "nupdownTimeSec";
            this.nupdownTimeSec.Size = new System.Drawing.Size(62, 20);
            this.nupdownTimeSec.TabIndex = 20;
            this.nupdownTimeSec.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Each step takes ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "steps.";
            // 
            // nupdownReal
            // 
            this.nupdownReal.Location = new System.Drawing.Point(59, 37);
            this.nupdownReal.Name = "nupdownReal";
            this.nupdownReal.Size = new System.Drawing.Size(50, 20);
            this.nupdownReal.TabIndex = 17;
            this.nupdownReal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnDoReal
            // 
            this.btnDoReal.Location = new System.Drawing.Point(14, 36);
            this.btnDoReal.Name = "btnDoReal";
            this.btnDoReal.Size = new System.Drawing.Size(38, 23);
            this.btnDoReal.TabIndex = 16;
            this.btnDoReal.Text = "Do";
            this.btnDoReal.UseVisualStyleBackColor = true;
            this.btnDoReal.Click += new System.EventHandler(this.btnDoReal_Click);
            // 
            // statusStripReal
            // 
            this.statusStripReal.Location = new System.Drawing.Point(0, 128);
            this.statusStripReal.Name = "statusStripReal";
            this.statusStripReal.Size = new System.Drawing.Size(261, 22);
            this.statusStripReal.TabIndex = 1;
            this.statusStripReal.Text = "statusStrip1";
            // 
            // progressBarReal
            // 
            this.progressBarReal.Location = new System.Drawing.Point(0, 129);
            this.progressBarReal.Name = "progressBarReal";
            this.progressBarReal.Size = new System.Drawing.Size(261, 21);
            this.progressBarReal.TabIndex = 2;
            // 
            // ucRealProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBarReal);
            this.Controls.Add(this.statusStripReal);
            this.Controls.Add(this.gbxReal);
            this.Name = "ucRealProgressBar";
            this.Size = new System.Drawing.Size(261, 150);
            this.gbxReal.ResumeLayout(false);
            this.gbxReal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownTimeSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdownReal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxReal;
        private System.Windows.Forms.StatusStrip statusStripReal;
        private System.Windows.Forms.ProgressBar progressBarReal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupdownTimeSec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupdownReal;
        private System.Windows.Forms.Button btnDoReal;
    }
}
