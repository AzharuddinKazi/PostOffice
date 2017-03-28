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
    public partial class AdminView : Form
    {
        DataView dv = new DataView();
        SqlConnection con = new SqlConnection("server=SHREYAS-PC ; database=post ; uid=sa ; pwd=1234");
        public AdminView()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StockManagementSystem sms = new StockManagementSystem();

            this.Close();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            con.Open();

            DataTable dt = new DataTable();
            String str = "select * from assetsgrid1";
            dt.Load(new SqlCommand(str, con).ExecuteReader());
            dataGridView1.DataSource = dv = dt.DefaultView;
            con.Close();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            con.Open();

            if (dataGridView1.SelectedCells.Count > 0)
            {
                //int i=new int[10][10];

                String i = dataGridView1.SelectedCells[0].Value.ToString();

                //MessageBox.Show(i.ToString());

                SqlCommand cmd1=new SqlCommand("delete from assetsgrid1 where AssetNo="+i.ToString(),con);
                
                cmd1.ExecuteNonQuery();


                MessageBox.Show("deleted");

                


                con.Close();

                /*if (dataGridView1.Rows.Count > 1 && i != dataGridView1.Rows.Count - 1)
                {
                    cmd.CommandText = "DELETE FROM tb1 WHERE ID=" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "";
                    con.Open();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i].Index);
                    MessageBox.Show("Row Deleted");
                }
             }
             else 
             {
               MessageBox.Show("Please select a row");
             }*/

            }




        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
