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
    public partial class AssetsRepairing : Form
    {
        DataView dv = new DataView();
        SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");
        public AssetsRepairing()
        {
            InitializeComponent();
        }

        

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Reportwin rw = new Reportwin();
            rw.Show();
            
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            RepairGrid rg = new RepairGrid();
            rg.Show();
            this.Close();
        }*/

        private void AssetsRepairing_Load(object sender, EventArgs e)
        {
            con.Open();

            dateTimePicker2.Hide();
            label1.Hide();

            DataTable dt = new DataTable();
            String str = "select * from repairgrid1";
            dt.Load(new SqlCommand(str, con).ExecuteReader());
            dataGridView1.DataSource = dv = dt.DefaultView;



            SqlCommand cmd1 = new SqlCommand("select * from assetsgrid1 where AssetsStatus='notworking'", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["MachineNo"].ToString());
            }
            //comboBox1.Items.Add("ALL");

            con.Close();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select DateOfRepair from historygrid where MachineNo='" + comboBox1.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (textBox10.Text.Equals(""))
            {
                MessageBox.Show("Enter nature of repairing");
                return;
            }
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Enter amount");
                return;
            }


            if (dr.Read() && dr["DateOfRepair"].ToString() != "")
            {
                MessageBox.Show("Already gone for repair");

                dateTimePicker5.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBox10.Enabled = false;
                textBox1.Enabled = false;
                
            }
                

            else
            {
                SqlConnection con1 = new SqlConnection("server=KAZI ; database=post ; uid=sa ; pwd=sql2008");
                con1.Open();
                dateTimePicker5.Enabled = true;
                dateTimePicker1.Enabled = true;
                textBox10.Enabled = true;
                textBox1.Enabled = true;

                SqlCommand cmd1 = new SqlCommand("update historygrid set DateOfRepair='" + dateTimePicker5.Value.ToShortDateString() + "',NatureOfRepairing='" + textBox10.Text + "',AmountOfRepair='" + textBox1.Text + "',EstimatedDate='" + dateTimePicker1.Value.ToShortDateString() + "' where MachineNo='" + comboBox1.Text + "' and DateOfRepair='' and AssetsStatus='notworking'" , con1);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd5 = new SqlCommand("insert into repairgrid1 values('" + comboBox1.Text + "','" + dateTimePicker5.Value.ToShortDateString() + "','" + textBox10.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','')", con1);
                cmd5.ExecuteNonQuery();


                
                MessageBox.Show("Entered successfully");

                DataTable dt2 = new DataTable();
                String str1 = "select * from repairgrid1";
                dt2.Load(new SqlCommand(str1, con1).ExecuteReader());
                dataGridView1.DataSource = dv = dt2.DefaultView;

                con1.Close();
               
            }

            con.Close();
            
            /*catch (Exception ae)
            {

                MessageBox.Show("error updating");
            
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker5.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox10.Enabled = true;
            textBox1.Enabled = true;
            textBox10.Clear();
            textBox1.Clear();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //comboBox1.Enabled = false;
            toolStripButton1.Enabled = false;
            label11.Hide();
            label14.Hide();
            label16.Hide();
            label9.Hide();
            dateTimePicker1.Hide();
            dateTimePicker5.Hide();
            textBox1.Hide();
            textBox10.Hide();
            label1.Show();
            dateTimePicker2.Show();

            toolStripButton2.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd=new SqlCommand("update historygrid set ActualDate='"+dateTimePicker2.Value.ToShortDateString()+"' where ActualDate='' and MachineNo='"+comboBox1.Text+"' and AssetsStatus='notworking'",con);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("update repairgrid1 set ActualDate='" + dateTimePicker2.Value.ToShortDateString() + "' where ActualDate='' and MachineId='" + comboBox1.Text + "'", con);
            cmd1.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Updated");
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        
        }
    }

