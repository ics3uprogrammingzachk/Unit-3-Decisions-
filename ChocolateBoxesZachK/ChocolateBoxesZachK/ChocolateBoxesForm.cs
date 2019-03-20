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
                lblPrize.Text = "You get a honourable mention";
        }
    }
}
