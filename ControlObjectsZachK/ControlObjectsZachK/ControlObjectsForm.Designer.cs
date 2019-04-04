namespace ControlObjectsZachK
{
    partial class ControlObjectsForm
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
            this.lblColour = new System.Windows.Forms.Label();
            this.listColour = new System.Windows.Forms.ListBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(74, 59);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(120, 45);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change ";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(71, 187);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(81, 13);
            this.lblColour.TabIndex = 1;
            this.lblColour.Text = "This color is red";
            // 
            // listColour
            // 
            this.listColour.FormattingEnabled = true;
            this.listColour.Location = new System.Drawing.Point(152, 110);
            this.listColour.Name = "listColour";
            this.listColour.Size = new System.Drawing.Size(120, 56);
            this.listColour.TabIndex = 2;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(12, 129);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(100, 20);
            this.txtColour.TabIndex = 3;
            // 
            // ControlObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.listColour);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.btnChange);
            this.Name = "ControlObjectsForm";
            this.Text = "Control Objects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.ListBox listColour;
        private System.Windows.Forms.TextBox txtColour;
    }
}

