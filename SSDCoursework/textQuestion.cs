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
    public partial class textQuestion : Form
    {
        Player thisPlayer;
        public int Score;

        public textQuestion(Player ThisPlayer)
        {
            InitializeComponent();
            //paramenter passing
            thisPlayer = ThisPlayer;
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar3.Image = thisPlayer.Avatar;
            Score = thisPlayer.Score;
        }

        private void textQuestion_Load(object sender, EventArgs e)
        {

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //textbox 1
            if ((textBox1.Text == "location"))
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
            if ((textBox2.Text == "injury"))
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
            if ((textBox3.Text == "other services"))
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
            if ((textBox4.Text == "number injured"))
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
            if ((textBox5.Text == "extent of injury"))
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
            if ((textBox6.Text == "location repeated"))
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

            //disabled submit button after answering so that no additional points can be scored
            btnSubmit.Enabled = false;

            //enable next button to advance to next question
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            thisPlayer.Score = Score;
            Form randomizedRadioButtons = new randomizedRadioButtons(thisPlayer);
            randomizedRadioButtons.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        //    if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
        //        btnSubmit.Enabled = false;
        //    else
        //        btnSubmit.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void imgLightBulb_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you want to see the hint", "Show Hint?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                lblHint1.Visible = true;
                lblHint2.Visible = true;
                imgLightBulb.Enabled = false;
            }
            else
            {
                //Do Nothing
            }
        }
    }
}
