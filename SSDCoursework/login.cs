﻿using System;
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

            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a suitable username");
            }

            if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Please enter a suitable Password");
            }

            thisPlayer.Name = txtName.Text;
            thisPlayer.Password = txtPassword.Text;

            if (createFileFlag == false) //if the object already exists
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
            Form Menu = new Menu(thisPlayer);
            Menu.Show();

            //password validation
            string newPassword = txtPassword.Text;
            string repeatPassword = txtRepeat.Text;
            if (!string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(newPassword) && newPassword.Equals(repeatPassword))
            {
                MessageBox.Show("Your passwords do not match. Please try again");
            }
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
                        Form Menu= new Menu(players[i]);
                        Menu.Show();
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

        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    //forgiveness
        //    DialogResult result =
        //        MessageBox.Show("Are you sure you would like to quit the quiz?", "Exit Quiz",
        //        MessageBoxButtons.OKCancel,
        //        MessageBoxIcon.Warning);
        //    if (result.Equals(DialogResult.OK))
        //    {
        //        Application.Exit();
        //    }
        //    else
        //    {
        //        //Do Nothing
        //    }
        //}

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed

            Application.Exit();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void imgHelp_Click(object sender, EventArgs e)
        {
            Form loginHelp = new loginHelp();
            loginHelp.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}