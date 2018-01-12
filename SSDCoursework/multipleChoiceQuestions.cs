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
    public partial class multipleChoiceQuestions : Form
    {
        //declare any classes
        Player thisPlayer;
        public int Score { get; set; }

        public multipleChoiceQuestions(Player ThisPlayer)
        {
            InitializeComponent();
            //Parameter passing
            thisPlayer = ThisPlayer;
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar.Image = thisPlayer.Avatar;
        }

        private void multipleChoiceQuestions_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            radioButton7.Checked = true;
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("That's correct!");
                return;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                MessageBox.Show("Sorry that's incorrect!");
                return;
            }
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("That's correct!");
                return;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                MessageBox.Show("Sorry that's incorrect!");
                return;
            }
        }

        private void btnSubmit3_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                MessageBox.Show("That's correct!");
                return;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                MessageBox.Show("Sorry that's incorrect!");
                return;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form textQuestion = new textQuestion(thisPlayer);
            //textQuestion.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you would like to quit the quiz?", "Exit Quiz",
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if ((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked))
            //{
            //    btnSubmit1.Enabled = true;
            //}
            //else
            //{
            //    btnSubmit1.Enabled = false;
            //}
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //if ((radioButton4.Checked) || (radioButton5.Checked) || (radioButton6.Checked))
            //{
            //    btnSubmit2.Enabled = true;
            //}
            //else
            //{
            //    btnSubmit2.Enabled = false;
            //}
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //if ((radioButton7.Checked) || (radioButton8.Checked) || (radioButton9.Checked))
            //{
            //    btnSubmit3.Enabled = true;
            //}
            //else
            //{
            //    btnSubmit3.Enabled = false;
            //}
        }
    }
}
