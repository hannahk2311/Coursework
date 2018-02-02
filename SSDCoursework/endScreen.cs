using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework
{
    public partial class endScreen : Form
    {
        //declare classes
        Player thisPlayer;
        public int Score;

        public endScreen(Player ThisPlayer)
        {
            InitializeComponent();
            thisPlayer = ThisPlayer;
            Score = thisPlayer.Score;
            checkHighscore();
            lblHighScore.MaximumSize = new Size(615, 70);
            lblHighScore.AutoSize = true;
        }

        public void checkHighscore() //checks if score is bigger than high score / if user has a new high score
        {
            if (thisPlayer.Score + 1 > thisPlayer.HighScore)
            {
                thisPlayer.HighScore = thisPlayer.Score;
                lblHighScore.Text = "Congratulations! you have beaten your previous high score!\n- Your new high score is now" + thisPlayer.HighScore.ToString();
            }
            else
            {
                lblHighScore.Text = "You haven't beat your high score yet,\n- better luck next time!";
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You will be taken to the Main Menu?", "Return to Main Menu?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                thisPlayer.Score = 0;
                this.Hide();
                Form Menu = new Menu(thisPlayer);
                Menu.Show();
            }
        }
    }
}
