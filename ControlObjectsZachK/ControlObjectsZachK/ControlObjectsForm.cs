/*
 * Created by: Zachary Kranabetter
 * Created on: April 1 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program changes the color of control objects 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlObjectsZachK
{
    public partial class ControlObjectsForm : Form
    {
        public ControlObjectsForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                //Change the color to green
                aControlObject.BackColor = Color.Green;

                //Change the labels to red
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Red;
                }

                //Change the labels to red
                if (aControlObject.GetType() == typeof(TextBox))
                {
                    aControlObject.BackColor = Color.Blue;
                }
            }
        }
    }
}
