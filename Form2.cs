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
        public Form2()
        {
            InitializeComponent();

            // Fill labels with statistical data
            FillP1Statistics();
            FillP2Statistics();
        }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSaveP1Stats_Click(object sender, EventArgs e)
        {
            int player = 1;
            SaveStats(player);
        }

        private void btnSaveP2Stats_Click(object sender, EventArgs e)
        {
            int player = 2;
            SaveStats(player);
        }

        private Boolean SaveStats(int player)
        {
            // Store all variables we want to save as string
            string content = "";

            if (player == 1)
            {
                content =
                    $"p1gp: {GameData.p1GamesPlayed}\n" +
                    $"p1w: {GameData.p1Wins}\n" +
                    $"p1d: {GameData.p1Draws}\n" +
                    $"p1l: {GameData.p1Losses}\n" +
                    $"p1bj: {GameData.p1BlackJacks}\n";
            } else
            {
                content =
                    $"p2gp: {GameData.p2GamesPlayed}\n" +
                    $"p2w: {GameData.p2Wins}\n" +
                    $"p2d: {GameData.p2Draws}\n" +
                    $"p2l: {GameData.p2Losses}\n" +
                    $"p2bj: {GameData.p2BlackJacks}";
            }

            var result = sfdSaveStats.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                File.WriteAllText(sfdSaveStats.FileName, content);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLoadP1Stats_Click(object sender, EventArgs e)
        {
            int player = 1;
            LoadStats(player);
        }

        private void btnLoadP2Stats_Click(object sender, EventArgs e)
        {
            int player = 2;
            LoadStats(player);
        }

        private Boolean LoadStats(int player)
        {
            var result = ofdOpenStats.ShowDialog(this);
            if (result == DialogResult.OK) {
                string path = ofdOpenStats.FileName;
                string[] data = File.ReadAllLines(path);

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
