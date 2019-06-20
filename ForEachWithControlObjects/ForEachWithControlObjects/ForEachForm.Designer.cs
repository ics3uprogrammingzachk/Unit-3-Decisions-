namespace ForEachWithControlObjects
{
    partial class ForEachForm
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
            this.btnChange = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.chbCheckBox = new System.Windows.Forms.CheckBox();
            this.grbBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(338, 205);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(105, 48);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(572, 234);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(48, 20);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Label";
            // 
            // chbCheckBox
            // 
            this.chbCheckBox.AutoSize = true;
            this.chbCheckBox.Location = new System.Drawing.Point(444, 96);
            this.chbCheckBox.Name = "chbCheckBox";
            this.chbCheckBox.Size = new System.Drawing.Size(111, 24);
            this.chbCheckBox.TabIndex = 2;
            this.chbCheckBox.Text = "Check Box";
            this.chbCheckBox.UseVisualStyleBackColor = true;
            // 
            // grbBox
            // 
            this.grbBox.Location = new System.Drawing.Point(56, 214);
            this.grbBox.Name = "grbBox";
            this.grbBox.Size = new System.Drawing.Size(167, 128);
            this.grbBox.TabIndex = 3;
            this.grbBox.TabStop = false;
            this.grbBox.Text = "Group Box";
            // 
            // ForEachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbBox);
            this.Controls.Add(this.chbCheckBox);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnChange);
            this.Name = "ForEachForm";
            this.Text = "For Each Zach K";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.CheckBox chbCheckBox;
        private System.Windows.Forms.GroupBox grbBox;
    }
}

