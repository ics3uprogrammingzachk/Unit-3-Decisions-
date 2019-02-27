namespace GuessingGameZachK
{
    partial class frmGuessingGame
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
            this.lblGuessTheNumber = new System.Windows.Forms.Label();
            this.picCheckmarkX = new System.Windows.Forms.PictureBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckmarkX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuessTheNumber
            // 
            this.lblGuessTheNumber.AutoSize = true;
            this.lblGuessTheNumber.Location = new System.Drawing.Point(12, 62);
            this.lblGuessTheNumber.Name = "lblGuessTheNumber";
            this.lblGuessTheNumber.Size = new System.Drawing.Size(182, 13);
            this.lblGuessTheNumber.TabIndex = 0;
            this.lblGuessTheNumber.Text = "Guess the interger between 1 and 10";
            // 
            // picCheckmarkX
            // 
            this.picCheckmarkX.Image = global::GuessingGameZachK.Properties.Resources.checkmark;
            this.picCheckmarkX.Location = new System.Drawing.Point(180, 163);
            this.picCheckmarkX.Name = "picCheckmarkX";
            this.picCheckmarkX.Size = new System.Drawing.Size(150, 86);
            this.picCheckmarkX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckmarkX.TabIndex = 1;
            this.picCheckmarkX.TabStop = false;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(200, 59);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(15, 89);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Green;
            this.lblCorrect.Location = new System.Drawing.Point(12, 182);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(138, 42);
            this.lblCorrect.TabIndex = 4;
            this.lblCorrect.Text = "Correct!";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(12, 182);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(148, 42);
            this.lblIncorrect.TabIndex = 5;
            this.lblIncorrect.Text = "Incorrect";
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.picCheckmarkX);
            this.Controls.Add(this.lblGuessTheNumber);
            this.Name = "frmGuessingGame";
            this.Text = "Guessing Game";
            ((System.ComponentModel.ISupportInitialize)(this.picCheckmarkX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessTheNumber;
        private System.Windows.Forms.PictureBox picCheckmarkX;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
    }
}

