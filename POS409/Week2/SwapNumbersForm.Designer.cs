namespace Week2
{
    partial class frmSwapNumbers
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
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSwapNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.lstA.Location = new System.Drawing.Point(13, 27);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(82, 95);
            this.lstA.TabIndex = 0;
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.Items.AddRange(new object[] {
            "100",
            "220",
            "330",
            "420",
            "550"});
            this.lstB.Location = new System.Drawing.Point(223, 27);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(82, 95);
            this.lstB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "List A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "List B";
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(111, 88);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(94, 23);
            this.btnSwap.TabIndex = 4;
            this.btnSwap.Text = "Swap List";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSwapNumber
            // 
            this.btnSwapNumber.Location = new System.Drawing.Point(111, 47);
            this.btnSwapNumber.Name = "btnSwapNumber";
            this.btnSwapNumber.Size = new System.Drawing.Size(94, 23);
            this.btnSwapNumber.TabIndex = 5;
            this.btnSwapNumber.Text = "Swap Number";
            this.btnSwapNumber.UseVisualStyleBackColor = true;
            this.btnSwapNumber.Click += new System.EventHandler(this.btnSwapNumber_Click);
            // 
            // frmSwapNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 143);
            this.Controls.Add(this.btnSwapNumber);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstB);
            this.Controls.Add(this.lstA);
            this.Name = "frmSwapNumbers";
            this.Text = "Swap Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSwapNumber;
    }
}