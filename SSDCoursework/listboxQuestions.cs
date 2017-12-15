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

        private void listboxQuestions_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //COMBO BOX 1
            if(comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //COMBO BOX 2
            if (comboBox2.SelectedIndex == 1)
            {
                pictureBox2.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //COMBO BOX 3
            if (comboBox3.SelectedIndex == 1)
            {
                pictureBox3.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //COMBO BOX 4
            if (comboBox4.SelectedIndex == 1)
            {
                pictureBox4.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //COMBO BOX 5
            if (comboBox5.SelectedIndex == 0)
            {
                pictureBox5.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //COMBO BOX 6
            if (comboBox6.SelectedIndex == 1)
            {
                pictureBox6.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //COMBO BOX 7
            if (comboBox7.SelectedIndex == 2)
            {
                pictureBox7.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //COMBO BOX 8
            if (comboBox8.SelectedIndex == 3)
            {
                pictureBox8.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //textQuestion textQuestion = new textQuestion;
            //textQuestion.ShowDialog();
            //this.Close();
        }
    }
}
