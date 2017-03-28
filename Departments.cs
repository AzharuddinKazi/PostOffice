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
    public partial class Departments : Form
    {
        SqlConnection con = new SqlConnection("server= WIN-7-PC; database= post ; uid=sa ; pwd=1234");
        public Departments()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select isnull(max(dept_no),0) from department", con);
            /*SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["AssetNo"].ToString();
            }*/
            int count = Convert.ToInt16(cmd.ExecuteScalar().ToString());
            count++;
            con.Close();

            if (textBox6.Text.Equals(""))
            {
                MessageBox.Show("Enter Department");
            }
                
            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select dept_name from department where dept_name='"+textBox6.Text+"'",con);
                SqlDataReader dr = cmd1.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Department Already Exists");
                    dr.Close();
                   
                }
                   

                else
                {
                    SqlConnection con1 = new SqlConnection("server=KAZI ; database=post ; uid=sa ; pwd=sql2008");
                    con1.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into department values('"+count+"','"+textBox6.Text+"')",con1);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Department added successfully");
                    con1.Close();
                }
                con.Close();


            }
            
        }


        private void Departments_Load(object sender, EventArgs e)
        {

        }
    }
}
