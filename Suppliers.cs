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
    public partial class Suppliers : Form
    {
        SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");
        public Suppliers()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SuppliersGrid sg = new SuppliersGrid();
            sg.Show();
            this.Close();
        }

        private void addtrip_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into suppliergrid1(SID,Name,Phone,City,PostalCode,Country,Street) values('" + sid.Text + "','" + sname.Text + "','" + sphone.Text + "','" + scity.Text + "','" + spcode.Text + "','" + scountry.Text + "','" + conname.Text + "')", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("data inserted");

            sid.Clear();
            sname.Clear();
            sphone.Clear();
            scity.Clear();
            spcode.Clear();
            scountry.Clear();
            conname.Clear();

            sid.Text = Autogenerate.autogen("suppliergrid1", "SID");

            con.Close();

           
            showtrip.Enabled = false;
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            addtrip.Enabled = true;
            
            showtrip.Enabled = true;

            sid.Text=Autogenerate.autogen("suppliergrid1","SID");
        }

        private void edittrip_Click(object sender, EventArgs e)
        {
            addtrip.Enabled = false;
            
            showtrip.Enabled = true;
        }

        private void savetrip_Click(object sender, EventArgs e)
        {
            addtrip.Enabled = true;
            
            showtrip.Enabled = true;
        }

        private void mvebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
