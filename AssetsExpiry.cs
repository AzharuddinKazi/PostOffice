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
    public partial class AssetsExpiry : Form
    {
        public AssetsExpiry()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            StockManagementSystem sms = new StockManagementSystem();
            sms.Show();
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            RepairedMachine rm = new RepairedMachine();
            rm.Show();
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExpiryReport er = new ExpiryReport();
            er.Show();
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExpiredMachine em = new ExpiredMachine();
            em.Show();
            this.Close();
        }
    }
}
