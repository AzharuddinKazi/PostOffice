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
    public partial class RepairReport : Form
    {
        public RepairReport()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AssetsRepairing ar = new AssetsRepairing();
            ar.Show();
            this.Close();
        }

     }
}
