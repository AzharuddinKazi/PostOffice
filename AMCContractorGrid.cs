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
    public partial class AMCContractorGrid : Form
    {
        public AMCContractorGrid()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            amcgridtxt.Clear();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            StockManagementSystem sms = new StockManagementSystem();
            sms.Show();
            this.Close();
        }

        private void AMCContractorGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postDataSet.amccontractor1' table. You can move, or remove it, as needed.
            this.amccontractor1TableAdapter.Fill(this.postDataSet.amccontractor1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
