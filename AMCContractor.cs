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
    public partial class AMCContractor : Form
    {
        SqlConnection con = new SqlConnection("server=SHREYAS-PC ; database=post ; uid=sa ; pwd=1234");
        public AMCContractor()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            amcreportwin am = new amcreportwin();
            am.Show();
        }

       

        private void AMCContractor_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from assetsgrid1", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                machineidcom.Items.Add(dr["MachineNo"].ToString());
            }
            con.Close();
        }

        private void machineidcom_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select SupplierId,WarrantyUpTo from assetsgrid1 where MachineNo='"+machineidcom.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["SupplierId"].ToString();
                conname.Text = dr["WarrantyUpTo"].ToString();
            }
            con.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from AmcReport where MachineNo='"+machineidcom.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("contract already exists");
            }
            else
            {
                SqlConnection con1 = new SqlConnection("server=KAZI ; database=post ; uid=sa ; pwd=sql2008");
                con1.Open();
                SqlCommand cmd2 = new SqlCommand("insert into AmcReport values('" + machineidcom.Text + "','" + conname.Text + "','" + amccdatetime.Value.ToShortDateString() + "','" + textBox1.Text + "','" + amcamt.Text + "')", con1);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("maintenance details inserted");
                con1.Close();
            }

            
            con.Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
