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
    public partial class FinalReport : Form
    {
        public FinalReport()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AssetsDetails ad = new AssetsDetails();
            ad.Show();
            this.Close();
        }
    }
}
