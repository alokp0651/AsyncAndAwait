namespace AsyncAndAwait
{
    partial class Form1
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
            this.ProcessFile = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProcessFile
            // 
            this.ProcessFile.Location = new System.Drawing.Point(190, 59);
            this.ProcessFile.Name = "ProcessFile";
            this.ProcessFile.Size = new System.Drawing.Size(407, 66);
            this.ProcessFile.TabIndex = 0;
            this.ProcessFile.Text = "Process File";
            this.ProcessFile.UseVisualStyleBackColor = true;
            this.ProcessFile.Click += new System.EventHandler(this.ProcessFile_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(199, 202);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(0, 16);
            this.lblcount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.ProcessFile);
            this.Name = "Form1";
            this.Text = "Count Charachters in this file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessFile;
        private System.Windows.Forms.Label lblcount;
    }
}

