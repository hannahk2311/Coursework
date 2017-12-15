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
        public int Score { get; set; }

        public textQuestion(Player ThisPlayer)
        {
            InitializeComponent();
            thisPlayer = ThisPlayer;
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar3.Image = thisPlayer.Avatar;
        }

        private void textQuestion_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //textbox 1
            if ((textBox1.Text == "Location") || (textBox1.Text == "location"))
            {
                img1.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //textbox 2
            if ((textBox2.Text == "Injury") || (textBox2.Text == "injury"))
            {
                img2.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //textbox 3
            if ((textBox3.Text == "Other services") || (textBox3.Text == "other services"))
            {
                img3.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //textbox 4
            if ((textBox4.Text == "Number injured") || (textBox4.Text == "number injured"))
            {
                img4.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //textbox 5
            if ((textBox5.Text == "Extent of injury") || (textBox5.Text == "extent of injury"))
            {
                img5.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }
            //textbox 6
            if ((textBox6.Text == "Location repeated") || (textBox6.Text == "location repeated"))
            {
                img6.Visible = true;
                Score += 1;
                lblScore.Text = Score.ToString();
            }

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
