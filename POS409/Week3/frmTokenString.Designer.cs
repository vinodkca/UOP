namespace Week3
{
    partial class frmTokenString
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
            this.lblInputString = new System.Windows.Forms.Label();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.lblTokenList = new System.Windows.Forms.Label();
            this.txtTokenList = new System.Windows.Forms.TextBox();
            this.lblOutputString = new System.Windows.Forms.Label();
            this.txtOutputString = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSimpleGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputString
            // 
            this.lblInputString.AutoSize = true;
            this.lblInputString.Location = new System.Drawing.Point(13, 23);
            this.lblInputString.Name = "lblInputString";
            this.lblInputString.Size = new System.Drawing.Size(67, 13);
            this.lblInputString.TabIndex = 0;
            this.lblInputString.Text = "Inpute String";
            // 
            // txtInputString
            // 
            this.txtInputString.Location = new System.Drawing.Point(87, 23);
            this.txtInputString.Multiline = true;
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputString.Size = new System.Drawing.Size(185, 46);
            this.txtInputString.TabIndex = 1;
            // 
            // lblTokenList
            // 
            this.lblTokenList.AutoSize = true;
            this.lblTokenList.Location = new System.Drawing.Point(16, 94);
            this.lblTokenList.Name = "lblTokenList";
            this.lblTokenList.Size = new System.Drawing.Size(57, 13);
            this.lblTokenList.TabIndex = 2;
            this.lblTokenList.Text = "Token List";
            // 
            // txtTokenList
            // 
            this.txtTokenList.Location = new System.Drawing.Point(87, 94);
            this.txtTokenList.Name = "txtTokenList";
            this.txtTokenList.Size = new System.Drawing.Size(185, 20);
            this.txtTokenList.TabIndex = 3;
            // 
            // lblOutputString
            // 
            this.lblOutputString.AutoSize = true;
            this.lblOutputString.Location = new System.Drawing.Point(19, 155);
            this.lblOutputString.Name = "lblOutputString";
            this.lblOutputString.Size = new System.Drawing.Size(69, 13);
            this.lblOutputString.TabIndex = 4;
            this.lblOutputString.Text = "Output String";
            // 
            // txtOutputString
            // 
            this.txtOutputString.Location = new System.Drawing.Point(87, 155);
            this.txtOutputString.Multiline = true;
            this.txtOutputString.Name = "txtOutputString";
            this.txtOutputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputString.Size = new System.Drawing.Size(185, 46);
            this.txtOutputString.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(98, 227);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSimpleGenerate
            // 
            this.btnSimpleGenerate.Location = new System.Drawing.Point(6, 227);
            this.btnSimpleGenerate.Name = "btnSimpleGenerate";
            this.btnSimpleGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnSimpleGenerate.TabIndex = 8;
            this.btnSimpleGenerate.Text = "Simple";
            this.btnSimpleGenerate.UseVisualStyleBackColor = true;
            this.btnSimpleGenerate.Click += new System.EventHandler(this.btnSimpleGenerate_Click);
            // 
            // frmTokenString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSimpleGenerate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtOutputString);
            this.Controls.Add(this.lblOutputString);
            this.Controls.Add(this.txtTokenList);
            this.Controls.Add(this.lblTokenList);
            this.Controls.Add(this.txtInputString);
            this.Controls.Add(this.lblInputString);
            this.Name = "frmTokenString";
            this.Text = "Token String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputString;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Label lblTokenList;
        private System.Windows.Forms.TextBox txtTokenList;
        private System.Windows.Forms.Label lblOutputString;
        private System.Windows.Forms.TextBox txtOutputString;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSimpleGenerate;
    }
}

