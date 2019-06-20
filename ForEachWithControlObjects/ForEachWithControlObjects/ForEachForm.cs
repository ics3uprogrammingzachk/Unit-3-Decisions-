using System;
using System.Collections.Generic;
using System.ComponentModel;
/*
 * Created by: Zachary Kranabetter
 * Created on: April 1st 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Control Objects
 * This program switchs the color of all control objects to gold when the change button is pressed
*/
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachWithControlObjects
{
    public partial class ForEachForm : Form
    {
        public ForEachForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                // make everything gold
                aControlObject.BackColor = Color.Gold;
            } 
        }
    }
}
