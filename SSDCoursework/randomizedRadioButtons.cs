using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SSDCoursework
{
    public partial class randomizedRadioButtons : Form
    {
        //declare any classes
        Player thisPlayer;
        Questions[] arrayList = new Questions[3];
        int[] dummyArray = new int[3] { -1, -1, -1 };
        public int Score;
        int correctAnsElement;

        public randomizedRadioButtons(Player ThisPlayer)
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

        private void randomizedRadioButtons_Load(object sender, EventArgs e)
        {
            try
            {
                int arrayLength = 0;
                string file_name = "F:\\Computing\\28-01-18 SSDCoursework\\SSDCoursework\\rdbQuestions.txt";

                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(file_name);

                //goes through the text file and reads into the array of objects
                for (int i = 0; i <= 2; i++)
                {
                    int questionNo = int.Parse(objReader.ReadLine());
                    String question = objReader.ReadLine();
                    String ans1 = objReader.ReadLine();
                    String ans2 = objReader.ReadLine();
                    String ans3 = objReader.ReadLine();
                    string correctAns = objReader.ReadLine();
                    arrayList[i] = new Questions(questionNo, question, ans1, ans2, ans3, correctAns);
                }

                arrayLength = arrayList.Length;

                Random rnd = new Random();
                int randomElement;
                do
                {
                    randomElement = rnd.Next(arrayLength);
                } while (dummyArray[randomElement] != -1);
                correctAnsElement = randomElement;
                dummyArray[randomElement] = 1;
                lblQNumber.Text = arrayList[randomElement].QuestionNo.ToString();
                lblQuestion.Text = arrayList[randomElement].Question;
                rdbAnswer1.Text = arrayList[randomElement].Ans1;
                rdbAnswer2.Text = arrayList[randomElement].Ans2;
                rdbAnswer3.Text = arrayList[randomElement].Ans3;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdbAnswer1.Checked == true)
            {
                if (rdbAnswer1.Text == arrayList[correctAnsElement].CorrectAns)
                {
                    imgCorrect1.Visible=true;
                    Score += 2;
                    lblScore.Text = Score.ToString();
                }
                else
                {
                    imgIncorrect1.Visible=true;
                }
            }
            if (rdbAnswer2.Checked == true)
            {
                if (rdbAnswer2.Text == arrayList[correctAnsElement].CorrectAns)
                {
                    imgCorrect2.Visible=true;
                    Score += 2;
                    lblScore.Text = Score.ToString();
                }
                else
                {
                    imgIncorrect2.Visible=true;
                }
            }
            if (rdbAnswer3.Checked == true)
            {
                if (rdbAnswer3.Text == arrayList[correctAnsElement].CorrectAns)
                {
                    imgCorrect3.Visible=true;
                    Score += 2;
                    lblScore.Text = Score.ToString();
                }
                else
                {
                    imgIncorrect3.Visible=true;
                }
            }

            //disable radio buttons after submit button is clicked so answers cannot be changed and resubmitted
            rdbAnswer1.Enabled = false;
            rdbAnswer2.Enabled = false;
            rdbAnswer3.Enabled = false;

            //disable submit button so that no extra points can be added
            btnSubmit.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure you want to move on?", "Next Page",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                this.Hide();
                thisPlayer.Score = Score;
                Form endScreen = new endScreen(thisPlayer);
                endScreen.Show();
            }
            else
            {
                //Do Nothing
            }
        }

        private void imgHelp_Click(object sender, EventArgs e)
        {
            Form easyRadioButtonsHelp = new easyRadioButtonsHelp();
            easyRadioButtonsHelp.Show();
        }
    }
}
