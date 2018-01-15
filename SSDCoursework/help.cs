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
    public partial class help : Form
    {
        string currentForm;

        string listBox = "This is a drop down list question. Click the arrow on the end of each list box to display the possible answers. \n\n- Once you have answered all the questions click the [Submit Answers] button to check your answers, then click the [Next] button to move to the next question. \n- If you wish to quit press the [Close Quiz] button.";
        string dragDrop = "This is a drag and drop question. On each of the pictures press and hold, then drag them across to the correct answer.\n\n- Once you have completed them click the [Next Question] button to move to the next question, or press [Close Quiz] to quit.";
        string radioButtons = "These are radio button questions. you must select one button from each question and click [Submit] to check your answer.\n\n- Once you have completed al the questions click [Next] to see your final score and compare to the top 10 scores on the quiz.\n\n- click the [Close Quiz] button to quit";




        public help(string currentForm)
        {
            InitializeComponent();
        }
    }
}
