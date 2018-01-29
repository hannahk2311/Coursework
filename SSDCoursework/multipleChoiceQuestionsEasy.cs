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
    public partial class multipleChoiceQuestionsEasy : Form
    {
        //declare any classes
        Player thisPlayer;
        public int Score;

        public multipleChoiceQuestionsEasy(Player ThisPlayer)
        {
            InitializeComponent();
            //Parameter passing
            thisPlayer = ThisPlayer;
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar.Image = thisPlayer.Avatar;
            Score = thisPlayer.Score;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
                  //advance to next form
            //this.Hide();
            //Form textQuestion = new textQuestion(thisPlayer);
            //textQuestion.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you would like to quit the quiz?", "Exit Quiz",
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
    }
}
