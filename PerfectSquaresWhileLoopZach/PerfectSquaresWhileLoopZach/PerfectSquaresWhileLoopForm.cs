/*
 * Created by: Zachary Kranabetter
 * Created on: March 27 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares with While Loop
 * This program lets the user enter a number with a numeric up-down box 
 * and then the program calculates each perfect square up to that number
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

namespace PerfectSquaresWhileLoopZach
{
    public partial class PerfectSquaresWhileLoopForm : Form
    {
        public PerfectSquaresWhileLoopForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            int endingValue;
            int value = 1;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            // clear the listbox
            lstPerfectSquares.Items.Clear();

            // get the user's end value selection from the numeric updown box
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            while (value <= endingValue)
            {
                // take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // check if it's a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    // tell the user that this number is a perfect square
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");
                }

                // refresh the screen
                this.Refresh();

                // increment the value
                value = value + 1;
            }
        }
    }
}
