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
    public partial class listboxQuestions : Form
    {
        Player thisPlayer;
        public int Score = 0;
        
        public listboxQuestions(Player ThisPlayer)
        {
            InitializeComponent();
            thisPlayer = ThisPlayer; //this player identifier is now set to equal the object that was passed in as a parameter
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar.Image = thisPlayer.Avatar;

            
        }

        private void listboxQuestions_Load(object sender, EventArgs e)
        {
            //Question 1
            comboBox1.Items.Add("unconscious but breathing"); //CORRECT
            comboBox1.Items.Add("conscious but not breathing");
            //Question 2
            comboBox2.Items.Add("high");
            comboBox2.Items.Add("low"); //CORRECT
            //Question 3
            comboBox3.Items.Add("fast");
            comboBox3.Items.Add("slow"); //CORRECT
            //Question 4
            comboBox4.Items.Add("80");
            comboBox4.Items.Add("120"); //CORRECT
            comboBox4.Items.Add("160");
            //Question 5
            comboBox5.Items.Add("2"); //CORRECT
            comboBox5.Items.Add("5");
            comboBox5.Items.Add("8");
            //Question 6
            comboBox6.Items.Add("15");
            comboBox6.Items.Add("30"); //CORRECT
            comboBox6.Items.Add("60");
            //Question 7
            comboBox7.Items.Add("responsive and breathing");
            comboBox7.Items.Add("unresponsive and breathing");
            comboBox7.Items.Add("unresponsive and not breathing"); //CORRECT
            //Question 8
            comboBox8.Items.Add("tired");
            comboBox8.Items.Add("hungry");
            comboBox8.Items.Add("calm");
            comboBox8.Items.Add("violent"); //CORRECT
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
                //end quiz and go to slash screen
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //COMBO BOX 1
            if(comboBox1.SelectedIndex == 0)
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
            if (comboBox2.SelectedIndex == 1)
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
            if (comboBox4.SelectedIndex == 1)
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
            if (comboBox5.SelectedIndex == 0)
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
            if (comboBox6.SelectedIndex == 1)
            {
                imgCorrect6.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect6.Visible = true;
            }
            //COMBO BOX 7
            if (comboBox7.SelectedIndex == 2)
            {
                imgCorrect7.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect7.Visible = true;
            }
            //COMBO BOX 8
            if (comboBox8.SelectedIndex == 3)
            {
                imgCorrect8.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect8.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //advance to next question form
            this.Hide();
            thisPlayer.Score = Score;
            Form matchingQuestions = new matchingQuestions(thisPlayer); //create instance of Form1 and pass it the object thisPlayer
            matchingQuestions.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
