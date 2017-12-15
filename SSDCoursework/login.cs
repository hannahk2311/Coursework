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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SSDCoursework
{
    public partial class login : Form
    {
        Player thisPlayer = new Player();
        Player[] players;
        bool createFileFlag = false;

        public login()
        {
            InitializeComponent();
            readFileToArray();
        }

        private void readFileToArray()
        {
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sr = File.OpenRead("Players.bin");
                players = (Player[])bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                players = new Player[1];
                createFileFlag = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty)
            {
                thisPlayer.Name = txtName.Text;
                this.Hide();
                //Form Form1 = new listbox(thisPlayer);
                //Form1.Show();
            }
            else
                MessageBox.Show("Please insert some text", "EnterName", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            thisPlayer.Name = txtName.Text;
            thisPlayer.Password = txtPassword.Text;

            if (createFileFlag == false) //if the binary file already exists
                Array.Resize(ref players, players.Length + 1); //make the array bigger by one element
            players[players.Length - 1] = thisPlayer; //load this new player into the new element of the array
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                sw = File.OpenWrite("Players.bin");
                bf.Serialize(sw, players);
                sw.Close();
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            createFileFlag = false;

            readFileToArray();
            this.Hide();
            Form listboxQuestions = new listboxQuestions(thisPlayer); //create instance of Form1 and pass it the object thisPlayer
            listboxQuestions.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool foundFlag = false;
            for(int i=0; i<players.Length; i++)
            {
                if (players[i].Name == txtLoginName.Text)
                {
                    foundFlag = true;
                    if (players[i].Password == txtLoginPassword.Text)
                    {
                        this.Hide();
                        Form listboxQuestions = new listboxQuestions(players[i]); //create instance of Form1 and pass it the object thisPlayer
                        listboxQuestions.Show();
                    }
                }
            }



            if (foundFlag == false)
                MessageBox.Show("User does not exist");

        }

        private void pic_avatar1_Click(object sender, EventArgs e)
        {

        }

        private void imgAvatar1_Click(object sender, EventArgs e)
        {
            thisPlayer.Avatar = imgAvatar1.Image;

        }

        private void imgAvatar2_Click(object sender, EventArgs e)
        {
            thisPlayer.Avatar = imgAvatar2.Image;
        }
    }
}