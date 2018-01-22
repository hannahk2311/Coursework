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
    public partial class loginHelp : Form
    {
        public loginHelp()
        {
            InitializeComponent();
        }

        private void loginHelp_Load(object sender, EventArgs e)
        {
            richTextBoxHelp.Text = Properties.Resources.helpLogin;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //forgiveness
            DialogResult result =
                MessageBox.Show("Are you sure?", "Return to Login Form",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                this.Hide();
            }
            else
            {
                //Do Nothing
            }
        }
    }
}
