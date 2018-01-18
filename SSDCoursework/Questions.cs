using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework
{
    class Questions
    {
        int questionNo;
        string question;
        string ans1;
        string ans2;
        string ans3;
        string correctAns;

        public Questions()
        {
            questionNo = 0;
            question = "";
            ans1 = "";
            ans2 = "";
            ans3 = "";
            correctAns = "";
        }

        public Questions(int questionNo, string question, string ans1, string ans2, string ans3, string correctAns)
        {
            QuestionNo = questionNo;
            Question = question;
            Ans1 = ans1;
            Ans2 = ans2;
            Ans3 = ans3;
            CorrectAns = correctAns;
        }

        public int QuestionNo
        {
            get { return questionNo; }
            set { questionNo = value; }
        }
        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string Ans1
        {
            get { return ans1; }
            set { ans1 = value; }
        }

        public string Ans2
        {
            get { return ans2; }
            set { ans2 = value; }
        }

        public string Ans3
        {
            get { return ans3; }
            set { ans3 = value; }
        }

        public string CorrectAns
        {
            get { return correctAns; }
            set { correctAns = value; }
        }
    }
}
