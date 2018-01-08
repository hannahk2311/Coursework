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
        //declare class's and array's
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
            //creating a binary file and adding to the array

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
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //"sign in" section
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
            Form listboxQuestions = new listboxQuestions(thisPlayer);
            listboxQuestions.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //"login" section
            bool foundFlag = false;
            for(int i=0; i<players.Length; i++)
            {
                //username exists
                if (players[i].Name == txtLoginName.Text)
                {
                    foundFlag = true;
                    
                    //password exists
                    if (players[i].Password == txtLoginPassword.Text)
                    {
                        this.Hide();

                        //open next form
                        Form listboxQuestions = new listboxQuestions(players[i]);
                        listboxQuestions.Show();
                    }
                }
            }
            //login user does not exist
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

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();

            //if close button is pressed they will be taken back to splash screen
            Form splashScreen = new splashScreen();
            splashScreen.Show();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed

            Application.Exit();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtRepeat.Text))
                btnCreate.Enabled = false;
            else
                btnCreate.Enabled = true;
        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginName.Text) || string.IsNullOrEmpty(txtLoginPassword.Text))
                btnLogin.Enabled = false;
            else
                btnLogin.Enabled = true;
        }
    }
}