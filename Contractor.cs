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
    public partial class Contractor : Form
    {
        public Contractor()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            StockManagementSystem sms = new StockManagementSystem();
            sms.Show();
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ContractorGrid cg = new ContractorGrid();
            cg.Show();
            this.Close();
        }

       
    }
}
