/*
     * Created by: Zachary Kranabetter
     * Created on: 27-2-19
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Number Guessing Game
     * This program lets the user guess a number and tells them whether their guess was correct or incorrect.
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
using System.Media;

namespace GuessingGameZachK
{
    public partial class frmGuessingGame : Form
    {
        const double CORRECT_ANSWER = 8;
        public frmGuessingGame()
        {
            InitializeComponent();
            picCheckmarkX.Hide();
            lblCorrect.Hide();
            lblIncorrect.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double Guess = Convert.ToDouble(txtGuess.Text);
            
            if (Guess == CORRECT_ANSWER)
            {
                this.picCheckmarkX.Image = Properties.Resources.checkmark;
                picCheckmarkX.Show();
                lblIncorrect.Hide();
                lblCorrect.Show();
                SoundPlayer correct = new SoundPlayer(@"nice-work.wav");
                correct.Play();
            }

            else
            { 
                this.picCheckmarkX.Image = Properties.Resources.red_x;
                picCheckmarkX.Show();
                lblCorrect.Hide();
                lblIncorrect.Show();
                SoundPlayer incorrect = new SoundPlayer(@"maybe-next-time.wav");
                incorrect.Play();
            }
        }
    }
}
