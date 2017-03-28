using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Post
{
    public partial class AMCReport : Form
    {
        SqlConnection con = new SqlConnection("server=SHREYAS-PC ; database=post ; uid=sa ; pwd=1234");
        public AMCReport()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AMCContractor amcc = new AMCContractor();
            amcc.Show();
            this.Close();
        }

        private void AMCReport_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from assetsgrid1", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["MachineNo"].ToString());
            }
            con.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

    }
}
