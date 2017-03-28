using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Post
{
    public partial class AssetsGrid : Form
    {
        DataView dv = new DataView();
        SqlConnection con = new SqlConnection("server=WIN-7-PC ; database=post ; uid=sa ; pwd=1234");
        public AssetsGrid()
        {
            InitializeComponent();
        }

        private void exitstrip_Click(object sender, EventArgs e)
        {
            AssetsDetails ad = new AssetsDetails();
            ad.Show();
            this.Close();
        }

        private void AssetsGrid_Load(object sender, EventArgs e)
        {
            con.Open();

            DataTable dt = new DataTable();
            String str = "select * from assetsgrid1";
            dt.Load(new SqlCommand(str, con).ExecuteReader());
            dataGridView1.DataSource = dv = dt.DefaultView;

            con.Close();
            

        }

        private void srchstrip_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "AssetNo =" + assettxtbx.Text ;
            if (assettxtbx.Text == "") dv.RowFilter = String.Empty;
        }

        private void allstrip_Click(object sender, EventArgs e)
        {
            con.Open();

            DataTable dt = new DataTable();
            String str = "select * from assetsgrid1";
            dt.Load(new SqlCommand(str, con).ExecuteReader());
            dataGridView1.DataSource = dv = dt.DefaultView;

            con.Close();
        }
    }
}
