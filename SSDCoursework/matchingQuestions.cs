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
    public partial class matchingQuestions : Form
    {
        //declare classes
        Player thisPlayer;
        public int Score ;


        //variable to store picture tag
        public static String selectedPicture;

        public matchingQuestions(Player ThisPlayer)
        {
            InitializeComponent();
            thisPlayer = ThisPlayer; //this player identifier is now set to equal the object that was passed in as a parameter
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar.Image = thisPlayer.Avatar;
            Score = thisPlayer.Score;
        }

        private void matchingQuestions_Load(object sender, EventArgs e)
        {
            //allow picture boxes to be dragged and dropped on load
            imgAbrasion.AllowDrop = true;
            imgAbrasionAns.AllowDrop = true;
            imgBurn.AllowDrop = true;
            imgBurnAns.AllowDrop = true;
            imgContusion.AllowDrop = true;
            imgContusionAns.AllowDrop = true;
        }

        private void imgBurn_Click(object sender, EventArgs e)
        {

        }




        //First picture

        private void imgBurn_MouseDown(object sender, MouseEventArgs e)
        {
            //store tag in selectedPicture
            selectedPicture = imgBurn.Tag.ToString();
            imgBurn.DoDragDrop(imgBurn.Image, DragDropEffects.Copy);
        }

        private void imgBurnAns_DragDrop(object sender, DragEventArgs e)
        {
            //allow selectedPicture to be dropped onto correct answer
            imgBurnAns.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            imgBurnAns.AllowDrop = false;
            if (selectedPicture == imgBurnAns.Tag.ToString())
            {
                //if it's correct
                imgTick3.Visible = true;
                Score += 1;
                selectedPicture = "";
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect3.Visible = true;
            }
        }

        private void imgBurnAns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }





        //Second picture

        private void imgAbrasion_MouseDown(object sender, MouseEventArgs e)
        {
            //store tag in selectedPicture
            selectedPicture = imgAbrasion.Tag.ToString();
            imgAbrasion.DoDragDrop(imgAbrasion.Image, DragDropEffects.Copy);
        }

        private void imgAbrasionAns_DragDrop(object sender, DragEventArgs e)
        {
            //allow selectedPicture to be dropped
            imgAbrasionAns.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            imgAbrasionAns.AllowDrop = false;
            if (selectedPicture == imgAbrasionAns.Tag.ToString())
            {
                //if it's correct
                imgTick1.Visible = true;
                Score += 1;
                selectedPicture = "";
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect1.Visible = true;
            }
        }

        private void imgAbrasionAns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }




        
        //Third picture

        private void imgContusion_MouseDown(object sender, MouseEventArgs e)
        {
            //store tag in selectedPicture
            selectedPicture = imgContusion.Tag.ToString();
            imgContusion.DoDragDrop(imgContusion.Image, DragDropEffects.Copy);
        }

        private void imgContusionAns_DragDrop(object sender, DragEventArgs e)
        {
            //allow image to be dropped
            imgContusionAns.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            imgContusionAns.AllowDrop = false;
            if (selectedPicture == imgContusionAns.Tag.ToString())
            {
                //if it's correct
                imgTick2.Visible = true;
                Score += 1;
                selectedPicture = "";
                lblScore.Text = Score.ToString();
            }
            else
            {
                imgIncorrect2.Visible = true;
            }
        }

        private void imgContusionAns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }





        //Buttons

        private void btnNext_Click(object sender, EventArgs e)
        {
            //advance to next question form
            this.Hide();
            thisPlayer.Score = Score;
            Form textQuestion = new textQuestion(thisPlayer);
            textQuestion.Show();
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
                //end quiz and go back to splash screen
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
