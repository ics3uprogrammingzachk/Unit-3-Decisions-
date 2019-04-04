/*
 * Created by: Zachary Kranabetter
 * Created on: April 3 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program keeps accepting input  (a mark between 0 and 100) then shows the running average
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

namespace RunningAverageZachK
{
    public partial class RunningAverageForm : Form
    {
        public RunningAverageForm()
        {
            InitializeComponent();
        }

        // declare my global variables
        double totalMarks = 0;

        int counter = 0;

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            // declare my local variables
            double runningAverage;

            double mark;

            // increment the counter
            counter = counter + 1;

            // get the mark
            mark = Convert.ToDouble(txtMark.Text);

            // if the mark is -1 end the program
            if (mark == -1)
            {
                // disable the buttons
                this.btnCalculateAverage.Enabled = false;

                this.txtMark.Enabled = false;

                // tell ther user the program is over
                lblAverage.Text = ("The running average is over");
                 
                // hide the labels
                lblQuestion2.Hide();

                lblQuestion.Hide();
            }

            else if (mark > 0)
            {
                if (mark <= 100)
                {
                    // calculate the running average
                    totalMarks = totalMarks + mark;

                    runningAverage = (totalMarks / counter);

                    // display the running average
                    lblAverage.Text = ("Your average is " + runningAverage);
                }
            }         
        }
    }
}
