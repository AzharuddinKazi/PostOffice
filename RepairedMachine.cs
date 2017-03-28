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
    public partial class RepairedMachine : Form
    {
        public RepairedMachine()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rpmhno.Clear();
        }

        

        private void RepairedMachine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postDataSet.repairgrid1' table. You can move, or remove it, as needed.
            this.repairgrid1TableAdapter.Fill(this.postDataSet.repairgrid1);

        }
    }
}
