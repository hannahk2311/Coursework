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
        Player thisPlayer;
        public int Score;
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
                imgTick3.Visible = true;
                Score += 1;
                selectedPicture = "";
                lblScore.Text = Score.ToString();
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
                imgTick1.Visible = true;
                Score += 1;
                selectedPicture = "";
                lblScore.Text = Score.ToString();
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
                imgTick2.Visible = true;
                Score += 1;
                selectedPicture = "";
                lblScore.Text = Score.ToString();
            }
        }

        private void imgContusionAns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }





        //Buttons

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form textQuestion = new textQuestion(thisPlayer);
            textQuestion.Show();
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
    }
}
