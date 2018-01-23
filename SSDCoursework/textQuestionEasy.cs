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
    public partial class textQuestionEasy : Form
    {
        //Declare classes
        Player thisPlayer;
        public int Score;

        public textQuestionEasy(Player ThisPlayer)
        {
            InitializeComponent();
            //parameter passing
            thisPlayer = ThisPlayer;
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar3.Image = thisPlayer.Avatar;
            Score = thisPlayer.Score;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
                    //Advance to next form
            //this.Hide();
            //thisPlayer.Score = Score;
            //Form randomizedRadioButtons = new randomizedRadioButtons(thisPlayer);
            //randomizedRadioButtons.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you want to log out?", "Log out?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                this.Hide();
                Form splashScreen = new splashScreen();
                splashScreen.Show();

                //Application.Exit();
            }
            else
            {
                //Do Nothing
            }
        }
        
    }
}
