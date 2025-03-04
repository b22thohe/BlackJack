using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class frmMain : Form
    {
        // Need Lists to hold each player's cards
        List<Card> P1Cards;
        List<Card> P2Cards;


        // Constructor
        public frmMain()
        {
            InitializeComponent();

            P1Cards = new List<Card>();
            P2Cards = new List<Card>();

            // Setup the game
            InitializeGame();

            // Update the game board
            UpdateBoard();
        }

        private void UpdateBoard()
        {
            // Clear the board
            ClearBoard();

            // Display card images
            for (int i = 1; i < 3; i++)
            {
                foreach (var card in i == 1 ? P1Cards : P2Cards)
                {
                    Panel panel = i == 1 ? flpP1 : flpP2;
                    PictureBox pb = new PictureBox()
                    {
                        ImageLocation = $"playing-cards\\{card.ImageFileName}",
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(60, 105)
                    };

                    panel.Controls.Add(pb);
                }

                // Add card values
                if (i == 1)
                {
                    lblP1ScoreOutput.Text = Card.Sum(P1Cards).ToString();
                }
                else
                {
                    lblP2ScoreOutput.Text = Card.Sum(P2Cards).ToString();
                }

                // Check if bust
                if (i == 1)
                {
                    if (IsBusted(Convert.ToInt16(lblP1ScoreOutput.Text)))
                    {
                        MessageBox.Show("You are busted!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        GameData.p2Wins += 1;
                        UpdateWinsLabels();
                        InitializeGame();
                        ClearBoard();
                    }
                }
                else
                {
                    if (IsBusted(Convert.ToInt16(lblP2ScoreOutput.Text)))
                    {
                        MessageBox.Show("You are busted!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        GameData.p1Wins += 1;
                        UpdateWinsLabels();
                        InitializeGame();
                        ClearBoard();
                    }
                }

                // Check if 21
                if (i == 1)
                {
                    if (IsTwentyone(Convert.ToInt16(lblP1ScoreOutput.Text)))
                    {
                        MessageBox.Show("Player 1 got BlackJack!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        GameData.p1BlackJacks += 1;
                        GameData.p1Wins += 1;
                        UpdateBlackJackLabels();
                        ClearBoard();
                        InitializeGame();
                    }
                } 
                else
                {
                    if (IsTwentyone(Convert.ToInt16(lblP2ScoreOutput.Text)))
                    {
                        MessageBox.Show("Player 2 got BlackJack!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        GameData.p2BlackJacks += 1;
                        GameData.p2Wins += 1;
                        UpdateBlackJackLabels();
                        ClearBoard();
                        InitializeGame();
                    }
                }
            }

            // TODO: Update score labels
        }

        private Boolean IsBusted(int score)
        {
            if (score > 21) {
                return true;
            } else
            {
                return false;
            }
        }

        private Boolean IsTwentyone(int score) {
            if (score == 21) {
                return true;
            } else
            {
                return false;
            }
        }

        private void ClearBoard()
        {
            flpP1.Controls.Clear();
            flpP2.Controls.Clear();
            lblP1ScoreOutput.Text = "0";
            lblP2ScoreOutput.Text = "0";
        }

        private void InitializeGame()
        {
            // Clear player hands
            P1Cards.Clear();
            P2Cards.Clear();

            // Make sure player 1 can act
            btnP1Hit.Enabled = true;
            btnP1Stay.Enabled = true;

            // Prevent player 2 from acting
            btnP2Hit.Enabled = false;
            btnP2Stay.Enabled = false;

            // Update games played variables
            GameData.p1GamesPlayed += 1;
            GameData.p2GamesPlayed += 1;
        }

        private void btnP1Hit_Click(object sender, EventArgs e)
        {
            P1Cards.Add(Card.RandomCard());
            UpdateBoard();
        }

        private void btnP2Hit_Click(object sender, EventArgs e)
        {
            P2Cards.Add(Card.RandomCard());
            UpdateBoard();
        }

        private void btnP1Stay_Click(object sender, EventArgs e)
        {
            // Prevent player 1 from acting
            btnP1Hit.Enabled = false;
            btnP1Stay.Enabled = false;

            // Enable player 2 to act
            btnP2Hit.Enabled = true;
            btnP2Stay.Enabled = true;
        }

        private void btnP2Stay_Click(object sender, EventArgs e)
        {
            DetermineWinner();
        }

        private void DetermineWinner()
        {
            int player1WinMargin = 21 - Convert.ToInt16(lblP1ScoreOutput.Text);
            int player2WinMargin = 21 - Convert.ToInt16(lblP2ScoreOutput.Text);

            if (player1WinMargin < player2WinMargin)
            {
                MessageBox.Show("Player 1 wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Update P1 statistics
                GameData.p1Wins += 1;

                // DEBUG - REMOVE
                Debug.WriteLine("--> P1 has won");
                Debug.WriteLine($"p1Wins: {GameData.p1Wins}, p1GamesPlayed: {GameData.p1GamesPlayed}");
            }
            else if (player1WinMargin > player2WinMargin)
            {
                MessageBox.Show("Player 2 wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GameData.p2Wins += 1;

                // DEBUG - REMOVE
                Debug.WriteLine("--> P2 has won");
                Debug.WriteLine($"p2Wins: {GameData.p2Wins}, p2GamesPlayed: {GameData.p2GamesPlayed}");
            }
            else
            {
                MessageBox.Show("It's a draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateWinsLabels();
            ClearBoard();
            InitializeGame();
        }

        private void UpdateBlackJackLabels()
        {
            lblP1BlackJackOutput.Text = Convert.ToString(GameData.p1BlackJacks);
            lblP2BlackJackOutput.Text = Convert.ToString(GameData.p2BlackJacks);
            UpdateWinsLabels();
        }

        private void UpdateWinsLabels()
        {
            lblP1WinOutput.Text = Convert.ToString(((double)GameData.p1Wins / GameData.p1GamesPlayed) * 100);
            lblP2WinOutput.Text = Convert.ToString(((double)GameData.p2Wins / GameData.p2GamesPlayed) * 100);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Form statForm = new Form2();
            statForm.Show();
        }
    }
}
