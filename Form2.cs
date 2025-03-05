using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Creates a form that displays statistics for both players
        /// </summary>
        public Form2()
        {
            InitializeComponent();

            // Call methods to fill labels with statistical data
            FillP1Statistics();
            FillP2Statistics();
        }

        /**
         * Methods takes data from GameData class and populates the labels on the form
         * **/
        private void FillP1Statistics()
        {
            lblP1GamesOutput.Text = Convert.ToString(GameData.p1GamesPlayed);
            lblP1WinsOutput.Text = Convert.ToString(GameData.p1Wins);
            lblP1DrawsOutput.Text = Convert.ToString(GameData.p1Draws);
            lblP1LossesOutput.Text = Convert.ToString(GameData.p1Losses);
            lblP1BlackJackOutput.Text = Convert.ToString(GameData.p1BlackJacks);
            lblP1WinPercentageOutput.Text = Convert.ToString(((double)GameData.p1Wins / GameData.p1GamesPlayed) * 100);
        }

        private void FillP2Statistics()
        {
            lblP2GamesOutput.Text = Convert.ToString(GameData.p2GamesPlayed);
            lblP2WinsOutput.Text = Convert.ToString(GameData.p2Wins);
            lblP2DrawsOutput.Text = Convert.ToString(GameData.p2Draws);
            lblP2LossesOutput.Text = Convert.ToString(GameData.p2Losses);
            lblP2BlackJackOutput.Text = Convert.ToString(GameData.p2BlackJacks);
            lblP2WinPercentageOutput.Text = Convert.ToString(((double)GameData.p2Wins / GameData.p2GamesPlayed) * 100);
        }

        /**
         * Closes the statistics form
         * **/
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /**
         * Method handles click on save p1 stats button
         * **/
        private void btnSaveP1Stats_Click(object sender, EventArgs e)
        {
            // Call method to save stats with parameter to indicate player 1
            int player = 1;
            SaveStats(player);
        }

        /**
         * Method handles click on save p2 stats button
         * **/
        private void btnSaveP2Stats_Click(object sender, EventArgs e)
        {
            // Call method to save stats with parameter to indicate player 2
            int player = 2;
            SaveStats(player);
        }

        /**
         * Method creates save dialog window and writes to selected file.
         * Returns boolean in case of need for handling this in later versions.
         * **/
        private Boolean SaveStats(int player)
        {
            // Initialize string that will hold save data
            string content = "";

            // If player 1 was sent as parameter...
            if (player == 1)
            {
                // Load up variable with player 1 statistics as key:value
                content =
                    $"p1gp: {GameData.p1GamesPlayed}\n" +
                    $"p1w: {GameData.p1Wins}\n" +
                    $"p1d: {GameData.p1Draws}\n" +
                    $"p1l: {GameData.p1Losses}\n" +
                    $"p1bj: {GameData.p1BlackJacks}\n";
            } else
            {
                // Load up variable with player 2 statistics as key:value
                content =
                    $"p2gp: {GameData.p2GamesPlayed}\n" +
                    $"p2w: {GameData.p2Wins}\n" +
                    $"p2d: {GameData.p2Draws}\n" +
                    $"p2l: {GameData.p2Losses}\n" +
                    $"p2bj: {GameData.p2BlackJacks}";
            }

            // Show save file dialog and store exit value (OK for Ok button, Cancel for cancel button)
            var result = sfdSaveStats.ShowDialog(this);
            // If user pressed Ok button...
            if (result == DialogResult.OK)
            {
                // Write statistics variable to file from save dialog
                File.WriteAllText(sfdSaveStats.FileName, content);
                return true;
            }
            else
            {
                // User pressed Cancel in save dialog
                return false;
            }
        }

        /**
         * Method handles click on load p1 stats button
         * **/
        private void btnLoadP1Stats_Click(object sender, EventArgs e)
        {
            // Call method to save stats with parameter to indicate player 1
            int player = 1;
            LoadStats(player);
        }

        /**
         * Method handles click on load p2 stats button
         * **/
        private void btnLoadP2Stats_Click(object sender, EventArgs e)
        {
            // Call method to save stats with parameter to indicate player 2
            int player = 2;
            LoadStats(player);
        }

        /**
         * Method creates load dialog window and reads from selected file to GameData class.
         * Returns boolean in case of need for handling this in later versions.
         * **/
        private Boolean LoadStats(int player)
        {
            // Show load file dialog and store exit value (OK for Ok button, Cancel for cancel button)
            var result = ofdOpenStats.ShowDialog(this);
            // If user pressed Ok button...
            if (result == DialogResult.OK) {
                // Store chosen path and filename from dialog
                string path = ofdOpenStats.FileName;
                // Use path to read from file into temporary storage
                string[] data = File.ReadAllLines(path);

                // Loop through temporary storage and store data in GameData class
                foreach (string line in data) {
                    string[] parts = line.Split(':');
                    int value = 0;
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        try
                        {
                            value = int.Parse(parts[1].Trim());
                        }
                        catch (Exception ex) { 
                            MessageBox.Show("Couldn't read data from file.", path + ": " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (player == 1)
                        {
                            // Use the key to store the value
                            switch (key)
                            {
                                case "p1gp":
                                    GameData.p1GamesPlayed = value;
                                    break;
                                case "p1w":
                                    GameData.p1Wins = value;
                                    break;
                                case "p1d":
                                    GameData.p1Draws = value;
                                    break;
                                case "p1l":
                                    GameData.p1Losses = value;
                                    break;
                                case "p1bj":
                                    GameData.p1BlackJacks = value;
                                    break;
                                default:
                                    MessageBox.Show("Unknown data found when reading from file.", path, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                    break;
                            }
                        } else
                        {
                            switch (key)
                            {
                                case "p2gp":
                                    GameData.p2GamesPlayed = value;
                                    break;
                                case "p2w":
                                    GameData.p2Wins = value;
                                    break;
                                case "p2d":
                                    GameData.p2Draws = value;
                                    break;
                                case "p2l":
                                    GameData.p2Losses = value;
                                    break;
                                case "p2bj":
                                    GameData.p2BlackJacks = value;
                                    break;
                                default:
                                    MessageBox.Show("Unknown data found when reading from file.", path, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                    break;
                            }
                        }
                    } else
                    {
                        return false;
                    }
                }

                return true;
            } else
            {
                return false;
            }
        }
    }
}
