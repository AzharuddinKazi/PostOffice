using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Post
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show(); 
        }

        private void WelcomePage_Load_1(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            ProgressBar1.PerformStep();
            if (ProgressBar1.Value == 3)
                lblloading.Text = "Loading.";

            if (ProgressBar1.Value == 6)
                lblloading.Text = "Loading..";

            if (ProgressBar1.Value == 9)
                lblloading.Text = "Loading...";

            if (ProgressBar1.Value == 12)
                lblloading.Text = "Loading....";

            if (ProgressBar1.Value == 15)
                lblloading.Text = "Loading.....";

            if (ProgressBar1.Value == 18)
                lblloading.Text = "Loading......";

            if (ProgressBar1.Value == 21)
                lblloading.Text = "Loading.......";

            if (ProgressBar1.Value == 24)
                lblloading.Text = "Loading........";

            if (ProgressBar1.Value == 27)
                lblloading.Text = "Loading.........";

            if (ProgressBar1.Value == 30)
                lblloading.Text = "Loading..........";

            if (ProgressBar1.Value == 39)
                lblloading.Text = "Preparing Instalation...";

            if (ProgressBar1.Value == 48)
                lblloading.Text = "Connecting Database...";

            if (ProgressBar1.Value == 57)
                lblloading.Text = "Collecting Data...";

            if (ProgressBar1.Value == 66)
                lblloading.Text = "Collecting Data...";

            if (ProgressBar1.Value == 75)
                lblloading.Text = "Loading Forms...";

            if (ProgressBar1.Value == 84)
                lblloading.Text = "Loading Images...";

            if (ProgressBar1.Value == 96)
                lblloading.Text = "  Welcome Click Here!!!";

            if (ProgressBar1.Value >= ProgressBar1.Maximum)
            {
                Timer1.Enabled = false;
                this.Hide();
                Login l = new Login();
                l.Show();
            }
        }

       

        
    }
}
