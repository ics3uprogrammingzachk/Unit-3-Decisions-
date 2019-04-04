/*
 * Created by: Zachary Kranabetter
 * Created on: March 28 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program  takes the capital letters from A to Z along with the corresponding Unicode value and place each in a listbox
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

namespace Unicode
{
    public partial class UnicodeForm : Form
    {
        public UnicodeForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare my variables
            string letters;
            int counter = 65;
            const int MAX_VALUE = 90;

            // clear items in the listbox
            lstLetters.Items.Clear();

            // set the counter to 65, make sure the counter isn't more then 90, increment the counter
            for (counter = 65; counter <= MAX_VALUE; counter++)
            {
                // convert the number to the corresponding letter
                letters = Char.ConvertFromUtf32(counter);

                // add it to the list
                lstLetters.Items.Add(letters + " -> " +counter);            
            }
        }
    }
}
