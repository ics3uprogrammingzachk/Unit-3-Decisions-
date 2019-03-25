/*
 * Created by: Zachary Kranabetter
 * Created on: March 20th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program let's the user say how many boxes they sold and if they will get a prize, small prize, or an hounourable mention
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

namespace ChocolateBoxesZachK
{
    public partial class ChocolateBoxesForm : Form
    {
        public ChocolateBoxesForm()
        {
            InitializeComponent();
        }

        private void txtNumberOfBoxes_TextChanged(object sender, EventArgs e)
        {
            double numberOfBoxes = Convert.ToDouble(txtNumberOfBoxes.Text);

            if (numberOfBoxes > 20)

                lblPrize.Text = "You get a Prize!";

            else if (numberOfBoxes > 9)
                lblPrize.Text = "You get a small Prize!";

            else
                lblPrize.Text = "You get a honorable mention";
        }
    }
}
