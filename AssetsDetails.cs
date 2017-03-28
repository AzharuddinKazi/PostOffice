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
    public partial class AssetsDetails : Form
    {
        SqlConnection con = new SqlConnection("server=WIN-7-PC; database=post ; uid=sa ; pwd=1234");
        String status;
        int assetno = 0;
        public AssetsDetails()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AssetsGrid ag = new AssetsGrid();
            ag.Show();
            this.Close();
        }

        private void historySheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorySheet hs = new HistorySheet();
            hs.Show();
            this.Close();
        }

        private void reportForTotalMachinePerDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForTotalMachinePerDepartment rmd = new ReportForTotalMachinePerDepartment();
            rmd.Show();
            this.Close();
        }

        private void fixedRegisterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FixedRegisterReport frr = new FixedRegisterReport();
            frr.Show();
            this.Close();
        }

        private void finalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalReport fr = new FinalReport();
            fr.Show();
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            con.Open();


            if (radioButton1.Checked)
            {
                status = "working";
            }
            else if(radioButton2.Checked)
            {
                status = "notworking";
            }

            String FinalMno = "PO_"+comboBox1.Text+"_"+dateTimePicker3.Value.Year.ToString()+"_"+textBox2.Text;


            SqlCommand cmd = new SqlCommand("insert into assetsgrid1 values(" + textBox2.Text + ",'" +FinalMno + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + textBox10.Text + "','" + dateTimePicker3.Value.ToShortDateString() + "','" + dateTimePicker4.Value.ToShortDateString() + "','"+dateTimePicker5.Value.ToShortDateString()+"','"+status+"','"+comboBox4.Text+"','"+comboBox2.Text+"')", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Machine "+FinalMno+" inserted successfully");

            textBox2.Clear();
            textBox6.Clear();
            textBox4.Clear();
            textBox8.Clear();
            textBox10.Clear();
            dateTimePicker3.Value.ToLocalTime();

            SqlCommand cmd1 = new SqlCommand("select isnull(max(AssetNo),0) from assetsgrid1", con);
            int count = Convert.ToInt16(cmd1.ExecuteScalar().ToString());
            count++;
            textBox2.Text = count.ToString();

            con.Close();
        }

        private void AssetsDetails_Load(object sender, EventArgs e)
        {
           /* SqlCommand cmd1 = new SqlCommand("select * from assetsgrid1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "department";*/
            //assetno = Autogenerate.autogen("assetsgrid1", "AssetNo");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select isnull(max(AssetNo),0) from assetsgrid1", con);
                /*SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["AssetNo"].ToString();
                }*/
                int count =Convert.ToInt16( cmd.ExecuteScalar().ToString());
                count++;
                textBox2.Text = count.ToString();



                SqlCommand cm = new SqlCommand("select * from department", con);
                SqlDataAdapter d1 = new SqlDataAdapter(cm);
                DataTable dtt1 = new DataTable();
                d1.Fill(dtt1);
                con.Close();
                comboBox2.DataSource = dtt1;
                comboBox2.DisplayMember = "dept_name";


                SqlCommand cmd2 = new SqlCommand("select * from Asset_Type", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                con.Close();
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "AssetType";


                SqlCommand cmd3 = new SqlCommand("select * from suppliergrid1", con);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd3);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                con.Close();

                
                comboBox4.DataSource = dt2;
                comboBox4.DisplayMember = "SID";
                
                
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AssetsEdit ae = new AssetsEdit();
            ae.Show();
            this.Close();
        }

        

        

        
        
       
    }
}
