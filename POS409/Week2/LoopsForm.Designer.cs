namespace Week2
{
    partial class frmLoops
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
            this.lstLoop = new System.Windows.Forms.ListBox();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnInfinite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLoop
            // 
            this.lstLoop.FormattingEnabled = true;
            this.lstLoop.Location = new System.Drawing.Point(34, 25);
            this.lstLoop.Name = "lstLoop";
            this.lstLoop.Size = new System.Drawing.Size(120, 160);
            this.lstLoop.TabIndex = 0;
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(199, 25);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "While Loop";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(199, 67);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 23);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "For Loop";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(199, 109);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 3;
            this.btnDoWhile.Text = "Do While Loop";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnInfinite
            // 
            this.btnInfinite.Location = new System.Drawing.Point(199, 151);
            this.btnInfinite.Name = "btnInfinite";
            this.btnInfinite.Size = new System.Drawing.Size(75, 23);
            this.btnInfinite.TabIndex = 4;
            this.btnInfinite.Text = "Infinite Loop";
            this.btnInfinite.UseVisualStyleBackColor = true;
            this.btnInfinite.Click += new System.EventHandler(this.btnInfinite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(199, 213);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(12, 213);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 6;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(104, 213);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(75, 23);
            this.btnArrayList.TabIndex = 7;
            this.btnArrayList.Text = "Array List";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // frmLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInfinite);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.lstLoop);
            this.Name = "frmLoops";
            this.Text = "Loops Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLoop;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnInfinite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnArrayList;
    }
}