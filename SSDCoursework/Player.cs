using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SSDCoursework
{
    [Serializable]
    public class Player
    {
        //attributes

        string name;
        string password;
        int score;
        int highScore;
        Image avatar;


        //constructors

        public Player()
        {
            name = "";
            password = "";
            score = 0;
            highScore = 0;
            avatar = null;
        }

        public Player(string name, string password, int score, int highScore, Image avatar)
        {
            Name = name;
            Password = password;
            Score = score;
            HighScore = highScore;
            Avatar = avatar;
        }


        //properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int HighScore
        {
            get { return highScore; }
            set { highScore = value; }
        }

        public Image Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        //methods
    }
}
