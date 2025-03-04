using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
