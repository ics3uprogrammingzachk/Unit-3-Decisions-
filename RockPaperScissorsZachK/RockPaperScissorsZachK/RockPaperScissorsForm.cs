/*
 * Created by: Zachary Kranabetter
 * Created on: 19-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program let's the user play a game of rock paper scissors with a computer
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

namespace RockPaperScissorsZachK
{
    public partial class frmRockPaperScissors : Form
    {
        const int MAX_VALUE = 3;
        const int MIN_VALUE = 1;
        int playerChoice, computerChoice;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            randomNumberGenerator = new Random();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            if (radPlayerRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radPlayerScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            

            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            if (computerChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }
            else if (computerChoice == SCISSORS)
            {
                this.radComputerScissors.Checked = true;
            }

            if (computerChoice == playerChoice)
            {
                lblWinner.Text = "It's a tie!";
            }
            else if (computerChoice == ROCK)
            {
                if (playerChoice == SCISSORS)
                {
                    lblWinner.Text = "You lost!";
                }

                else if (playerChoice == PAPER)
                {
                    lblWinner.Text = "You win!";
                }
            }

            else if (computerChoice == SCISSORS)
            {
                if (playerChoice == ROCK)
                {
                    lblWinner.Text = "You win!";
                }

                else if (playerChoice == PAPER)
                {
                    lblWinner.Text = "You lost!";
                }

                else if (computerChoice == PAPER)
                {

                    if (playerChoice == ROCK)
                    {
                        lblWinner.Text = "You win!";
                    }

                    else if (playerChoice == SCISSORS)
                    {
                        lblWinner.Text = "You lost!";
                    }
                }
            }
        }
    }
}
