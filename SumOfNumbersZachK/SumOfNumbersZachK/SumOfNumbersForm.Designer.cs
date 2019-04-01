namespace SumOfNumbersZachK
{
    partial class SumOfNumbersForm
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
            this.txt = new System.Windows.Forms.TextBox();
            this.lstSumNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(89, 89);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 0;
            // 
            // lstSumNumbers
            // 
            this.lstSumNumbers.FormattingEnabled = true;
            this.lstSumNumbers.Location = new System.Drawing.Point(80, 115);
            this.lstSumNumbers.Name = "lstSumNumbers";
            this.lstSumNumbers.Size = new System.Drawing.Size(120, 43);
            this.lstSumNumbers.TabIndex = 1;
            // 
            // SumOfNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstSumNumbers);
            this.Controls.Add(this.txt);
            this.Name = "SumOfNumbersForm";
            this.Text = "Sum Of Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ListBox lstSumNumbers;
    }
}

