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
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        //Use timer class
        Timer tmr;

        private void splashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;

        }

        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            login lf = new login();

            lf.Show();

            //hide this form

            this.Hide();
        }
    }
}
