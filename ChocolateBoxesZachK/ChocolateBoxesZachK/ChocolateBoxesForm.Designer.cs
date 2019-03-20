namespace ChocolateBoxesZachK
{
    partial class ChocolateBoxesForm
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
            this.txtNumberOfBoxes = new System.Windows.Forms.TextBox();
            this.lblPrize = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberOfBoxes
            // 
            this.txtNumberOfBoxes.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfBoxes.Location = new System.Drawing.Point(19, 97);
            this.txtNumberOfBoxes.Name = "txtNumberOfBoxes";
            this.txtNumberOfBoxes.Size = new System.Drawing.Size(100, 35);
            this.txtNumberOfBoxes.TabIndex = 0;
            this.txtNumberOfBoxes.TextChanged += new System.EventHandler(this.txtNumberOfBoxes_TextChanged);
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(12, 168);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(17, 19);
            this.lblPrize.TabIndex = 1;
            this.lblPrize.Text = "?";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(4, 71);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(268, 23);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "How many boxes did you sell?";
            // 
            // ChocolateBoxesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.txtNumberOfBoxes);
            this.Name = "ChocolateBoxesForm";
            this.Text = "Chocolate Boxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfBoxes;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblQuestion;
    }
}

