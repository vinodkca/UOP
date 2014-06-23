namespace Week4
{
    partial class frmOOPS
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
            this.btnPolymorphism = new System.Windows.Forms.Button();
            this.txtPolymorphism = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPolymorphism
            // 
            this.btnPolymorphism.Location = new System.Drawing.Point(35, 32);
            this.btnPolymorphism.Name = "btnPolymorphism";
            this.btnPolymorphism.Size = new System.Drawing.Size(108, 23);
            this.btnPolymorphism.TabIndex = 0;
            this.btnPolymorphism.Text = "Polymorphism";
            this.btnPolymorphism.UseVisualStyleBackColor = true;
            this.btnPolymorphism.Click += new System.EventHandler(this.btnPolymorphism_Click);
            // 
            // txtPolymorphism
            // 
            this.txtPolymorphism.Location = new System.Drawing.Point(181, 32);
            this.txtPolymorphism.Multiline = true;
            this.txtPolymorphism.Name = "txtPolymorphism";
            this.txtPolymorphism.Size = new System.Drawing.Size(339, 181);
            this.txtPolymorphism.TabIndex = 1;
            // 
            // frmOOPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 262);
            this.Controls.Add(this.txtPolymorphism);
            this.Controls.Add(this.btnPolymorphism);
            this.Name = "frmOOPS";
            this.Text = "OOPS Principle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPolymorphism;
        private System.Windows.Forms.TextBox txtPolymorphism;
    }
}