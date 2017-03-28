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
    public partial class History : Form
    {
        DataView dv = new DataView();
        String combo1, combo2, combo3;
       
        public History()
        {
            SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");

            InitializeComponent();
            BindData();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from department order by dept_no ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["dept_name"].ToString());
            }
            comboBox1.Items.Add("ALL");
            con.Close();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from asset_type ", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["AssetType"].ToString());
            }
            comboBox2.Items.Add("ALL");
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from historygrid order by AssetNo", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2["MachineNo"].ToString());
            }
            comboBox3.Items.Add("ALL");
            con.Close();
        }
        private void BindData()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("server=WIN-7-PC ; database=post ; uid=sa ; pwd=1234");
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from historygrid", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            dataGridView1.DataSource = dt;
        }

        private void History_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("AssetNo", typeof(string));
            dt.Columns.Add("MachinNo", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Configuration", typeof(string));
            dt.Columns.Add("BillNo", typeof(string));
            dt.Columns.Add("DateOfOrder", typeof(string));
            dt.Columns.Add("Cost", typeof(string));
            dt.Columns.Add("ReceivedDate", typeof(string));
            dt.Columns.Add("InstallationDate", typeof(string));
            dt.Columns.Add("WarrantyUpto", typeof(string));
            dt.Columns.Add("AssetStatus", typeof(string));
            dt.Columns.Add("SupplierId", typeof(string));
            dt.Columns.Add("Department", typeof(string));
            foreach (DataGridViewRow dgv in dataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value, dgv.Cells[10].Value, dgv.Cells[11].Value, dgv.Cells[12].Value, dgv.Cells[13].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("Sample.xml");
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");
            combo1 = comboBox1.Text;
            combo2 = comboBox2.Text;
            combo3 = comboBox3.Text;


            if (combo1.Equals("ALL") && combo2.Equals("ALL") && combo3.Equals("ALL"))
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("select * from historygrid except(select * from historygrid where MachineNo='ALL')", con);

                //SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                //da2.Fill(dt2);

                dt2.Load(new SqlCommand("select * from historygrid ", con).ExecuteReader());
                dataGridView1.DataSource = dv = dt2.DefaultView;
                con.Close();

            }
            else if (combo1 != "ALL" && combo2.Equals("ALL") && combo3.Equals("ALL"))
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("select * from historygrid except(select * from historygrid where MachineNo='ALL')", con);

                //SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                //da2.Fill(dt2);

                dt2.Load(new SqlCommand("select * from historygrid  where Location = '" + combo1 + "'", con).ExecuteReader());
                dataGridView1.DataSource = dv = dt2.DefaultView;
                con.Close();


            }

            else if (combo1 != "ALL" && combo2 != "ALL" && combo3.Equals("ALL"))
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("select * from historygrid except(select * from historygrid where MachineNo='ALL')", con);

                //SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                //da2.Fill(dt2);

                dt2.Load(new SqlCommand("select * from historygrid  where Location = '" + combo1 + "' AND Type = '" + combo2 + "' ", con).ExecuteReader());
                dataGridView1.DataSource = dv = dt2.DefaultView;
                con.Close();


            }

            else if (combo1 != "ALL" && combo2 != "ALL" && combo3 != "ALL")
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("select * from historygrid except(select * from historygrid where MachineNo='ALL')", con);

                //SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                //da2.Fill(dt2);

                dt2.Load(new SqlCommand("select * from historygrid  where Location = '" + combo1 + "' AND Type = '" + combo2 + "' AND MachineNo = '" + combo3 + "' ", con).ExecuteReader());
                dataGridView1.DataSource = dv = dt2.DefaultView;
                con.Close();


            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");
            combo1 = comboBox1.Text;
            combo2 = comboBox2.Text;
            combo3 = comboBox3.Text;

            /*con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from historygrid  where Department = '" + combo1 + "' AND Type = '" + combo2 + "' except(select * from historygrid where MachineNo='ALL' ) order by AssetNo", con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            comboBox3.DataSource = dt2;
            comboBox3.DisplayMember = "MachineNo";*/
        }
    }
}
