/*
     * Created by: Zachary Kranabetter
     * Created on: 27-2-19
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Number Guessing Game
     * This program lets the user guess a random number and tells them whether their guess was correct or incorrect.
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

            //hide everything
            picCheckmarkX.Hide();
            lblCorrect.Hide();
            lblIncorrect.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double guess = Convert.ToDouble(txtGuess.Text);

            //make the random number for the correct answer
            int correctGuess;
            Random randomNumberGenerator = new Random();
            const int MAX_VALUE = 10;
            const int MIN_VALUE = 1;
            correctGuess = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //check if the got it right
            if (guess == correctGuess)
            {
                this.picCheckmarkX.Image = Properties.Resources.checkmark;

                //display a checkmark and tell the user they guessed right
                picCheckmarkX.Show();
                lblIncorrect.Hide();
                lblCorrect.Show();

                //play the correct sound
                SoundPlayer correct = new SoundPlayer(@"nice-work.wav");
                correct.Play();
            }

            else
            { 
                this.picCheckmarkX.Image = Properties.Resources.red_x;

                //display an X and tell the user they guessed wrong
                picCheckmarkX.Show();
                lblCorrect.Hide();
                lblIncorrect.Show();

                //play the incorrect sound
                SoundPlayer incorrect = new SoundPlayer(@"maybe-next-time.wav");
                incorrect.Play();
            }
        }
    }
}
