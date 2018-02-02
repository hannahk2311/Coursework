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
    public partial class Menu : Form
    {
        Player thisPlayer;

        public Menu(Player ThisPlayer)
        {
            InitializeComponent();
            thisPlayer = ThisPlayer; //passing the current player object
            lblName.Text = thisPlayer.Name;
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar.Image = thisPlayer.Avatar;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            //close the current form
            this.Hide();

            //open first easy question form
            Form listBoxQuestionsEasy = new listBoxQuestionsEasy(thisPlayer);
            listBoxQuestionsEasy.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            //close current form
            this.Hide();

            //open first hard question form
            Form listboxQuestions = new listboxQuestions(thisPlayer);
            listboxQuestions.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you want to log out?", "Log out?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                //close menu form
                this.Hide();

                //open login without player obj
                Form login = new login();
                login.Show();
            }
            else
            {
                //Do Nothing
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {//forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you want to quit?", "Quit?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                //end quiz
                Application.Exit();
            }
            else
            {
                //Do Nothing
            } 
        }

        private void imgHelp_Click(object sender, EventArgs e)
        {
            Form menuHelp = new menuHelp();
            menuHelp.Show();
        }
    }
}
