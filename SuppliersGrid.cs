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
    public partial class SuppliersGrid : Form
    {
        String SID, sname;
        DataView dv = new DataView();
        SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");
        public SuppliersGrid()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            sidbox.Clear();
            snamebox.Clear();
            snamebox.Enabled = false;
            sidbox.Enabled = false;
            radioButton3.Checked = false;
            radioButton1.Checked = false;

            con.Open();
            sidbox.Enabled = false;
            snamebox.Enabled = false;
            DataTable dt = new DataTable();
            String str = "select * from suppliergrid1";
            dt.Load(new SqlCommand(str, con).ExecuteReader());
            dataGridView1.DataSource = dv = dt.DefaultView;
            con.Close();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            s.Show();
            this.Close();
        }

        private void SuppliersGrid_Load(object sender, EventArgs e)
        {
            con.Open();
            sidbox.Enabled = false;
            snamebox.Enabled = false;
            DataTable dt = new DataTable();
            String str = "select * from suppliergrid1";
            dt.Load(new SqlCommand(str, con).ExecuteReader());
            dataGridView1.DataSource = dv = dt.DefaultView;
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sidbox.Enabled = true;
                snamebox.Enabled = false;
                snamebox.Clear();
            }
            else if (radioButton3.Checked)
            {
                sidbox.Enabled = false;
                snamebox.Enabled = true;
                sidbox.Clear();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                sidbox.Enabled = false;
                snamebox.Enabled = true;
                sidbox.Clear();
            }
            else if (radioButton1.Checked)
            {
                snamebox.Enabled = false;
                sidbox.Enabled = true;
                snamebox.Clear();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            
            if (radioButton1.Checked)
            {
                dv.RowFilter = "SID like'%"+ sidbox.Text + "%'";
                if (sidbox.Text == "") dv.RowFilter = String.Empty;
            }
            else if (radioButton3.Checked)
            {
                dv.RowFilter = "Name like'%" + snamebox.Text + "%'";
                if (snamebox.Text == "") dv.RowFilter = String.Empty;
            }
            con.Close();
        }
        
        private void sidbox_TextChanged(object sender, EventArgs e)
        {
            SID = sidbox.Text;

        }

        private void snamebox_TextChanged(object sender, EventArgs e)
        {
            sname = snamebox.Text;
        }
        
       
    }
}
