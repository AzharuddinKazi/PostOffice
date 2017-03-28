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
    public partial class ExpiredMachine : Form
    {
        public ExpiredMachine()
        {
            InitializeComponent();
        }

        private void ExpiredMachine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postDataSet.expiredmachine1' table. You can move, or remove it, as needed.
            this.expiredmachine1TableAdapter.Fill(this.postDataSet.expiredmachine1);

        }
    }
}
