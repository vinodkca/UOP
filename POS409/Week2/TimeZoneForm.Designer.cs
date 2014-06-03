namespace Week2
{
    partial class frmTimeZone
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
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelTimeZone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCityTimeZone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTimeZone
            // 
            this.cmbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Location = new System.Drawing.Point(152, 12);
            this.cmbTimeZone.Name = "cmbTimeZone";
            this.cmbTimeZone.Size = new System.Drawing.Size(540, 21);
            this.cmbTimeZone.TabIndex = 0;
            this.cmbTimeZone.SelectedIndexChanged += new System.EventHandler(this.cmbTimeZone_SelectedIndexChanged);
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Location = new System.Drawing.Point(14, 12);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(91, 13);
            this.lblTimeZone.TabIndex = 1;
            this.lblTimeZone.Text = "Select Time Zone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time";
            // 
            // lblSelTimeZone
            // 
            this.lblSelTimeZone.AutoSize = true;
            this.lblSelTimeZone.Location = new System.Drawing.Point(152, 55);
            this.lblSelTimeZone.Name = "lblSelTimeZone";
            this.lblSelTimeZone.Size = new System.Drawing.Size(35, 13);
            this.lblSelTimeZone.TabIndex = 3;
            this.lblSelTimeZone.Text = "empty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a city and I will give you time zone.";
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.Location = new System.Drawing.Point(155, 110);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(120, 95);
            this.lstCity.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(155, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time Zone:";
            // 
            // lblCityTimeZone
            // 
            this.lblCityTimeZone.AutoSize = true;
            this.lblCityTimeZone.Location = new System.Drawing.Point(328, 156);
            this.lblCityTimeZone.Name = "lblCityTimeZone";
            this.lblCityTimeZone.Size = new System.Drawing.Size(35, 13);
            this.lblCityTimeZone.TabIndex = 9;
            this.lblCityTimeZone.Text = "empty";
            // 
            // frmTimeZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 262);
            this.Controls.Add(this.lblCityTimeZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelTimeZone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeZone);
            this.Controls.Add(this.cmbTimeZone);
            this.Name = "frmTimeZone";
            this.Text = "Time Zone";
            this.Load += new System.EventHandler(this.frmTimeZone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTimeZone;
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelTimeZone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCityTimeZone;

    }
}

