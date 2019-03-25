namespace FactorialDoWhileZach
{
    partial class FactorialDoWhileForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(191, 99);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(68, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(185, 73);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 22);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Calculate";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(215, 197);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(20, 21);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "?";
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.ItemHeight = 23;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(136, 124);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(181, 73);
            this.lstFactorialNumbers.TabIndex = 5;
            // 
            // FactorialDoWhileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 292);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FactorialDoWhileForm";
            this.Text = "Factorial DoWhile Zach K";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ListBox lstFactorialNumbers;
    }
}

