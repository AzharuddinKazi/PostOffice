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
    public partial class AssetsEdit : Form
    {
        String status = "",old_dept="";
        SqlConnection con = new SqlConnection("server=WIN-7-PC ; database=post ; uid=sa ; pwd=1234");
        public AssetsEdit()
        {
            InitializeComponent();
        }

        private void AssetsEdit_Load(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("select * from assetsgrid1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "MachineNo";

            SqlCommand cm = new SqlCommand("select * from department", con);
            SqlDataAdapter d1 = new SqlDataAdapter(cm);
            DataTable dtt1 = new DataTable();
            d1.Fill(dtt1);
            con.Close();
            comboBox2.DataSource = dtt1;
            comboBox2.DisplayMember = "dept_name";
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from assetsgrid1 where MachineNo='"+comboBox1.Text+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox5.Text = dr["AssetNo"].ToString();
                textBox1.Text=dr["TypeName"].ToString();
                textBox6.Text=dr["Model"].ToString();
                textBox4.Text=dr["Configuration"].ToString();
                textBox8.Text = dr["BillNo"].ToString();
                textBox3.Text = dr["DateOfOrder"].ToString();
                textBox10.Text = dr["Cost"].ToString();
                textBox7.Text = dr["ReceivedDate"].ToString();
                textBox9.Text = dr["InstallationDate"].ToString();
              old_dept = dr["department"].ToString();
              comboBox2.Text = old_dept;
                textBox11.Text = dr["WarrantyUpTo"].ToString();
                textBox12.Text = dr["SupplierId"].ToString();

                status = dr["AssetsStatus"].ToString();

                if (status.Equals("working"))
                {
                    radioButton1.Select();
                    toolStripButton2.Enabled = false;
                }

                else if (status.Equals("notworking"))
                {
                    radioButton2.Select();
                    toolStripButton2.Enabled = false;
                }
            }
            con.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd1 = new SqlCommand("insert into historygrid values('" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + textBox3.Text + "','" + textBox10.Text + "','" + textBox7.Text + "','" + old_dept+ "','" + textBox9.Text + "','" + textBox11.Text + "','" + status + "','" + textBox12.Text + "','','','','','')",con);
            cmd1.ExecuteNonQuery();


            SqlCommand cmd = new SqlCommand("update assetsgrid1 set department='"+comboBox2.Text+"',AssetsStatus ='"+status+"' where MachineNo='"+comboBox1.Text+"'",con);
            cmd.ExecuteNonQuery();



            con.Close();
            MessageBox.Show("updated");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            if (radioButton1.Checked)
            {
                status = "working";
            }
            else status = "notworking";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            if (radioButton2.Checked)
            {
                status = "notworking";
            }
            else status = "working";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
