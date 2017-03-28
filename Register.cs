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
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=WIN-7-PC ; database=post ; uid=sa ; pwd=1234");
            con.Open();
            if (Name.Text.Equals(""))
            {
                MessageBox.Show("Enter Name");
                return;
            }

            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Enter Username");
                return;
            }

            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Enter Password");
                return;
            }

            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Re-Enter Password");
                return;
            }

            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("Enter Contact");
                return;
            }

            if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("Enter Email_id");
                return;
            }
            if (textBox6.Text.Equals(""))
            {
                MessageBox.Show("Enter Address");
                return;
            }

            if (textBox2.Text.Equals(textBox3.Text))
            {
                
                SqlCommand cmd = new SqlCommand("insert into login values('" + Name.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + cbotype.Text + "','" + comboBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful");
                Login l = new Login();
                l.Show();
               // con.Close();
                this.Close();
            }

            else if (textBox2.Text != "'" + textBox3.Text + "'")
            {
                MessageBox.Show("Error");
                
            }
            con.Close();
            

      }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=WIN-7-PC ; database=post ; uid=sa ; pwd=1234");
            con.Open();
            SqlCommand cmd = new SqlCommand("select dept_name from department",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["dept_name"]);
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=WIN-7-PC; database=post ; uid=sa ; pwd=1234");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from login where Username='" + textBox1.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Username already exists");
            }
            else
            {
                MessageBox.Show("You may Proceed");
            }
            con.Close();
        }




    }
}