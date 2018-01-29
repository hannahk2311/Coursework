using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework
{
    public partial class listBoxQuestionsEasy : Form
    {

        Player thisPlayer;
        public int Score = 0;

        public listBoxQuestionsEasy(Player ThisPlayer)
        {
            InitializeComponent();
            thisPlayer = ThisPlayer; //this player identifier is now set to equal the object that was passed in as a parameter
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar.Image = thisPlayer.Avatar;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //COMBO BOX 1
            if (comboBox1.SelectedIndex == 1)
            {
                imgCorrect1.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect1.Visible = true;
            }
            //COMBO BOX 2
            if (comboBox2.SelectedIndex == 0)
            {
                imgCorrect2.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect2.Visible = true;
            }
            //COMBO BOX 3
            if (comboBox3.SelectedIndex == 1)
            {
                imgCorrect3.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect3.Visible = true;
            }
            //COMBO BOX 4
            if (comboBox4.SelectedIndex == 3)
            {
                imgCorrect4.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect4.Visible = true;
            }
            //COMBO BOX 5
            if (comboBox5.SelectedIndex == 1)
            {
                imgCorrect5.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect5.Visible = true;
            }
            //COMBO BOX 6
            if (comboBox6.SelectedIndex == 3)
            {
                imgCorrect6.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect6.Visible = true;
            }

            //disable all combo boxes so answers cannot be changed
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;

            //disable submit button so extra points can't be added
            btnSubmit.Enabled = false;

            //enable next button to move to the next question
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //advance to next question form
            this.Hide();
            thisPlayer.Score = Score;
            Form matchingQuestionsEasy = new matchingQuestionsEasy(thisPlayer); //create instance of current form and pass it the object thisPlayer
            matchingQuestionsEasy.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you want to log out?", "Log out?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                //end quiz and go to slash screen
                this.Hide();
                Form Menu = new Menu(thisPlayer);
                Menu.Show();

                //Application.Exit();
            }
            else
            {
                //Do Nothing
            }
        }
    }
}
