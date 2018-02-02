using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Help_Forms
{
    public partial class finishScreen : Form
    {
        Player thisPlayer;

        public finishScreen(Player ThisPlayer)
        {
            InitializeComponent();
            ThisPlayer = thisPlayer;
            checkHighscore();
            lblHighScore.MaximumSize = new Size(615, 70);
            lblHighScore.AutoSize = true;
        }

        public void checkHighscore()
        {
            if (thisPlayer.Score > thisPlayer.HighScore)
            {
                lblHighScore.Text = "Congratulations! you have beaten your previous high score!\n- Your new high score is now" + thisPlayer.HighScore.ToString();
                thisPlayer.HighScore = thisPlayer.Score;
            }
            else lblHighScore.Text = "You haven't beat your high score yet,\n- better luck next time!";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu(thisPlayer);
            Menu.Show();
        }
    }
}
