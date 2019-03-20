namespace RockPaperScissorsZachK
{
    partial class frmRockPaperScissors
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
            this.grbUserChoice = new System.Windows.Forms.GroupBox();
            this.radPlayerScissors = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.radComputerScissors = new System.Windows.Forms.RadioButton();
            this.radComputerPaper = new System.Windows.Forms.RadioButton();
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.grbUserChoice.SuspendLayout();
            this.grbComputerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUserChoice
            // 
            this.grbUserChoice.Controls.Add(this.radPlayerScissors);
            this.grbUserChoice.Controls.Add(this.radPlayerPaper);
            this.grbUserChoice.Controls.Add(this.radPlayerRock);
            this.grbUserChoice.Location = new System.Drawing.Point(56, 44);
            this.grbUserChoice.Name = "grbUserChoice";
            this.grbUserChoice.Size = new System.Drawing.Size(200, 100);
            this.grbUserChoice.TabIndex = 0;
            this.grbUserChoice.TabStop = false;
            this.grbUserChoice.Text = "User Choice";
            // 
            // radPlayerScissors
            // 
            this.radPlayerScissors.AutoSize = true;
            this.radPlayerScissors.Location = new System.Drawing.Point(7, 68);
            this.radPlayerScissors.Name = "radPlayerScissors";
            this.radPlayerScissors.Size = new System.Drawing.Size(64, 17);
            this.radPlayerScissors.TabIndex = 2;
            this.radPlayerScissors.TabStop = true;
            this.radPlayerScissors.Text = "Sicssors";
            this.radPlayerScissors.UseVisualStyleBackColor = true;
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Location = new System.Drawing.Point(7, 44);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(53, 17);
            this.radPlayerPaper.TabIndex = 1;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.Text = "Paper";
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Location = new System.Drawing.Point(7, 20);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(51, 17);
            this.radPlayerRock.TabIndex = 0;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.Text = "Rock";
            this.radPlayerRock.UseVisualStyleBackColor = true;
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.Controls.Add(this.radComputerScissors);
            this.grbComputerChoice.Controls.Add(this.radComputerPaper);
            this.grbComputerChoice.Controls.Add(this.radComputerRock);
            this.grbComputerChoice.Location = new System.Drawing.Point(56, 269);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Size = new System.Drawing.Size(200, 100);
            this.grbComputerChoice.TabIndex = 1;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computer Choice";
            // 
            // radComputerScissors
            // 
            this.radComputerScissors.AutoSize = true;
            this.radComputerScissors.Location = new System.Drawing.Point(7, 68);
            this.radComputerScissors.Name = "radComputerScissors";
            this.radComputerScissors.Size = new System.Drawing.Size(64, 17);
            this.radComputerScissors.TabIndex = 2;
            this.radComputerScissors.TabStop = true;
            this.radComputerScissors.Text = "Sicssors";
            this.radComputerScissors.UseVisualStyleBackColor = true;
            // 
            // radComputerPaper
            // 
            this.radComputerPaper.AutoSize = true;
            this.radComputerPaper.Location = new System.Drawing.Point(7, 44);
            this.radComputerPaper.Name = "radComputerPaper";
            this.radComputerPaper.Size = new System.Drawing.Size(53, 17);
            this.radComputerPaper.TabIndex = 1;
            this.radComputerPaper.TabStop = true;
            this.radComputerPaper.Text = "Paper";
            this.radComputerPaper.UseVisualStyleBackColor = true;
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(7, 20);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(51, 17);
            this.radComputerRock.TabIndex = 0;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(63, 194);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(153, 204);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(13, 13);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "?";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 455);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputerChoice);
            this.Controls.Add(this.grbUserChoice);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors";
            this.grbUserChoice.ResumeLayout(false);
            this.grbUserChoice.PerformLayout();
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserChoice;
        private System.Windows.Forms.RadioButton radPlayerScissors;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.RadioButton radComputerScissors;
        private System.Windows.Forms.RadioButton radComputerPaper;
        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblWinner;
    }
}

