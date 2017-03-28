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
    public partial class AssetsCategory : Form
    {
        SqlConnection con = new SqlConnection("server=SHREYAS-PC ; database=post ; uid=sa ; pwd=1234"); 
        public AssetsCategory()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            StockManagementSystem sms = new StockManagementSystem();
            sms.Show();
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select AssetType from Asset_Type where AssetType='"+textBox6.Text+"'",con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Asset Type already Present");
                con.Close();
            }

            else
            {
                SqlConnection con1 = new SqlConnection("server=SHREYAS-PC ; database=post ; uid=sa ; pwd=sql2008");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into Asset_Type values('"+textBox6.Text+"')",con1);
                cmd1.ExecuteNonQuery();
                con1.Close();

                MessageBox.Show("Asset Type Inserted Successfully");
            }

            
           
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
