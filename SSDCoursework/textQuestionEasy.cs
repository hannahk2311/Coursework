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
            //textbox 1
            if ((textBox1.Text == "999"))
            {
                imgCorrect1.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect1.Visible = true;
            }
            //textbox 2
            if ((textBox2.Text == "xray"))
            {
                imgCorrect2.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect2.Visible = true;
            }
            //textbox 3
            if((textBox3.Text=="face"))
            {
                imgCorrect3.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect3.Visible = true;
            }
            //textbox 4
            if ((textBox4.Text == "arms"))
            {
                imgCorrect4.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect4.Visible = true;
            }
            //textbox 5
            if ((textBox5.Text == "speech"))
            {
                imgCorrect5.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect5.Visible = true;
            }
            //textbox 6
            if ((textBox6.Text == "time"))
            {
                imgCorrect6.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect6.Visible = true;
            }

            //after submit is pressed all text boxes must be disabled to prevent changing of answers
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            //submit button must then also be disabled to prevent further addition of points
            btnSubmit.Enabled = false;

            //next button is then enabled so that the user can now advance to the next question
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Advance to next form
            this.Hide();
            thisPlayer.Score = Score;
            Form randomisedRadioButtonsEasy = new randomisedRadioButtonsEasy(thisPlayer);
            randomisedRadioButtonsEasy.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you want to return to the menu?", "Exit Quiz?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
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

        private void imgHelp_Click(object sender, EventArgs e)
        {
            Form easyTextboxHelp = new easyTextboxHelp();
            easyTextboxHelp.Show();
        }
    }
}
