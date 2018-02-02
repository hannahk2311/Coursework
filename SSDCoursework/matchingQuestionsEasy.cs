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
    public partial class matchingQuestionsEasy : Form
    {
        //declare classes
        Player thisPlayer;
        public int Score;

        //variable to store picture tag
        public static String selectedPicture;

        public matchingQuestionsEasy(Player ThisPlayer)
        {
            InitializeComponent();
            thisPlayer = ThisPlayer; //this player identifier is now set to equal the object that was passed in as a parameter
            lblName.Text = thisPlayer.Name;
            lblScore.Text = thisPlayer.Score.ToString();
            lblHighScore.Text = thisPlayer.HighScore.ToString();
            imgAvatar.Image = thisPlayer.Avatar;
            Score = thisPlayer.Score;
        }

        
        
        
        //Buttons
        private void btnNext_Click(object sender, EventArgs e)
        {
            //advance to next question form
            this.Hide();
            thisPlayer.Score = Score;
            Form textQuestionEasy = new textQuestionEasy(thisPlayer);
            textQuestionEasy.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you want to return to menu?", "Return to main menu?",
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

        private void matchingQuestionsEasy_Load(object sender, EventArgs e)
        {
            //allow icture boxes to be dragged and dropped on laod
            imgBandage.AllowDrop = true;
            imgBandageAns.AllowDrop = true;
            imgOxygenMask.AllowDrop = true;
            imgOxygenAns.AllowDrop = true;
            imgSling.AllowDrop = true;
            imgSlingAns.AllowDrop = true;
        }

        //first picture
        private void imgSling_MouseDown(object sender, MouseEventArgs e)
        {
            //store tag in selectedPicture
            selectedPicture = imgSling.Tag.ToString();
            imgSling.DoDragDrop(imgSling.Image, DragDropEffects.Copy);
        }

        private void imgSlingAns_DragDrop(object sender, DragEventArgs e)
        {
            //allow selectedPicture to be dragged ontocrrect answer
            imgSlingAns.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            imgSlingAns.AllowDrop = false;
            if (selectedPicture == imgSlingAns.Tag.ToString())
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







        //Second picture
        private void imgSlingAns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void imgBandage_MouseDown(object sender, MouseEventArgs e)
        {
            //store tag in selectedPicture
            selectedPicture = imgBandage.Tag.ToString();
            imgBandage.DoDragDrop(imgBandage.Image, DragDropEffects.Copy);
        }

        private void imgBandageAns_DragDrop(object sender, DragEventArgs e)
        {
            //allow image to be dropped
            imgBandageAns.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            imgBandageAns.AllowDrop = false;
            if (selectedPicture == imgBandageAns.Tag.ToString())
            {
                //if its correct
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

        private void imgBandageAns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }







        //private void imgOxygenMask_Click(object sender, EventArgs e)
        //{
        //    //store tag in selectedPicture
        //    selectedPicture = imgOxygenMask.Tag.ToString();
        //    imgOxygenMask.DoDragDrop(imgOxygenMask.Image, DragDropEffects.Copy);
        //}


        //Third picture
        private void imgOxygenMask_MouseDown(object sender, MouseEventArgs e)
        {
            //store tag in selectedPicture
            selectedPicture = imgOxygenMask.Tag.ToString();
            imgOxygenMask.DoDragDrop(imgOxygenMask.Image, DragDropEffects.Copy);
        }

        private void imgOxygenAns_DragDrop(object sender, DragEventArgs e)
        {
            //allow image to be dropped
            imgOxygenAns.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            imgOxygenAns.AllowDrop = false;
            if (selectedPicture == imgOxygenAns.Tag.ToString())
            {
                //if its correct
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

        private void imgOxygenAns_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void imgHelp_Click(object sender, EventArgs e)
        {
            Form easyDragDropHelp = new easyDragDropHelp();
            easyDragDropHelp.Show();
        }

        
    }
}
