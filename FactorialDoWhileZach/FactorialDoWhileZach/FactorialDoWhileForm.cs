/*
 * Created by: Zachary Kranabetter
 * Created on: 21-March-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial do while
 * This program calculates the factorial of a given number with a do while loop
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

namespace FactorialDoWhileZach
{
    public partial class FactorialDoWhileForm : Form
    {
        public FactorialDoWhileForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;
       
            //clear the items in the listbox
            this.lstFactorialNumbers.Items.Clear();

            //Initialize the final answer to 1
            factorialAnswer = 1;

            //Get the number from the user
            factorialNumber = Convert.ToDouble(txtInput.Text);

            //Set counter to 0
            factorialCounter = 0;

            do
            {
                factorialCounter = factorialCounter + 1;

                lstFactorialNumbers.Items.Add(factorialCounter);

                factorialAnswer = factorialCounter * factorialAnswer;


            } while (factorialCounter != factorialNumber);

            lblAnswer.Text = txtInput.Text + "! = " + Convert.ToString(factorialAnswer);
        }

    }
}
