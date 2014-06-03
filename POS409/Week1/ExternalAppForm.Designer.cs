namespace POS409
{
    partial class frmExternalApp
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
            this.btnText = new System.Windows.Forms.Button();
            this.txtTextFile = new System.Windows.Forms.TextBox();
            this.btnWord = new System.Windows.Forms.Button();
            this.txtWordFile = new System.Windows.Forms.TextBox();
            this.txtWebBrowser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWebBrowserNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(259, 34);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(132, 30);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "Open in notepad";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // txtTextFile
            // 
            this.txtTextFile.Location = new System.Drawing.Point(25, 40);
            this.txtTextFile.Multiline = true;
            this.txtTextFile.Name = "txtTextFile";
            this.txtTextFile.Size = new System.Drawing.Size(186, 25);
            this.txtTextFile.TabIndex = 1;
            this.txtTextFile.Text = "Files\\TextFile.txt";
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(259, 89);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(132, 30);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Open in word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // txtWordFile
            // 
            this.txtWordFile.Location = new System.Drawing.Point(25, 95);
            this.txtWordFile.Multiline = true;
            this.txtWordFile.Name = "txtWordFile";
            this.txtWordFile.Size = new System.Drawing.Size(186, 25);
            this.txtWordFile.TabIndex = 3;
            this.txtWordFile.Text = "Files\\WordFile.docx";
            // 
            // txtWebBrowser
            // 
            this.txtWebBrowser.Location = new System.Drawing.Point(25, 168);
            this.txtWebBrowser.Multiline = true;
            this.txtWebBrowser.Name = "txtWebBrowser";
            this.txtWebBrowser.Size = new System.Drawing.Size(186, 25);
            this.txtWebBrowser.TabIndex = 4;
            this.txtWebBrowser.Text = "university of phoenix fresno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open in WebBrowser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWebBrowserNotes
            // 
            this.lblWebBrowserNotes.AutoSize = true;
            this.lblWebBrowserNotes.Location = new System.Drawing.Point(22, 142);
            this.lblWebBrowserNotes.Name = "lblWebBrowserNotes";
            this.lblWebBrowserNotes.Size = new System.Drawing.Size(263, 13);
            this.lblWebBrowserNotes.TabIndex = 6;
            this.lblWebBrowserNotes.Text = "Open a Web Browser with a URL and a Search Query";
            // 
            // frmExternalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.lblWebBrowserNotes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWebBrowser);
            this.Controls.Add(this.txtWordFile);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.txtTextFile);
            this.Controls.Add(this.btnText);
            this.Name = "frmExternalApp";
            this.Text = "External App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.TextBox txtTextFile;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.TextBox txtWordFile;
        private System.Windows.Forms.TextBox txtWebBrowser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWebBrowserNotes;
    }
}