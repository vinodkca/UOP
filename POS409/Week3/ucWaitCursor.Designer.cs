namespace Week3
{
    partial class ucWaitCursor
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
            this.grpWaitCursor = new System.Windows.Forms.GroupBox();
            this.btnWait = new System.Windows.Forms.Button();
            this.updwnWait = new System.Windows.Forms.NumericUpDown();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.grpWaitCursor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updwnWait)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWaitCursor
            // 
            this.grpWaitCursor.Controls.Add(this.lblSeconds);
            this.grpWaitCursor.Controls.Add(this.updwnWait);
            this.grpWaitCursor.Controls.Add(this.btnWait);
            this.grpWaitCursor.Location = new System.Drawing.Point(4, 4);
            this.grpWaitCursor.Name = "grpWaitCursor";
            this.grpWaitCursor.Size = new System.Drawing.Size(156, 66);
            this.grpWaitCursor.TabIndex = 0;
            this.grpWaitCursor.TabStop = false;
            this.grpWaitCursor.Text = "Wait Cursor";
            // 
            // btnWait
            // 
            this.btnWait.Location = new System.Drawing.Point(7, 29);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(44, 23);
            this.btnWait.TabIndex = 0;
            this.btnWait.Text = "Wait";
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // updwnWait
            // 
            this.updwnWait.Location = new System.Drawing.Point(58, 31);
            this.updwnWait.Name = "updwnWait";
            this.updwnWait.Size = new System.Drawing.Size(38, 20);
            this.updwnWait.TabIndex = 1;
            this.updwnWait.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(102, 33);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "Seconds";
            // 
            // ucWaitCursor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpWaitCursor);
            this.Name = "ucWaitCursor";
            this.Size = new System.Drawing.Size(166, 78);
            this.grpWaitCursor.ResumeLayout(false);
            this.grpWaitCursor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updwnWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWaitCursor;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown updwnWait;
        private System.Windows.Forms.Button btnWait;
    }
}
